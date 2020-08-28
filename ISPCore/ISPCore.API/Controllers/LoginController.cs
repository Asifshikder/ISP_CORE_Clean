using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using ISPCore.API.Model;
using ISPCore.Domain.Entities;
using ISPCore.Persistence;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace ISPCore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private IConfiguration _config;
        private DBContext _context;
        public LoginController(IConfiguration config,DBContext context)
        {
            _config = config;
            _context = context;
        }


        [HttpGet]
        public IActionResult Login(string username, string password)
        {
            User loginUser = new User();
            loginUser.UserName = username;
            loginUser.Password = password;
            IActionResult response = Unauthorized();

            var user = AuthenticatedUser(loginUser);
            if (user != null)
            {
                var tokenSTR = GenerateJSONWebToken(user);
                response = Ok(new { token = tokenSTR });
            }
            return response;
        }

        private User AuthenticatedUser(User loginuser)
        {
            User user = null;
            Employee emp = _context.Employee.Where(s => s.LoginName == loginuser.UserName && s.Password == loginuser.Password).FirstOrDefault();
            if (emp!=null)
            {
                user = new User { UserName = emp.LoginName, Email = emp.Email, Password = emp.Password };
            }
            return user;
        }
        private string GenerateJSONWebToken(User userinfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub,userinfo.UserName),
                new  Claim(JwtRegisteredClaimNames.Email,userinfo.Email),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
            };
            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Issuer"],
                claims,
                expires: DateTime.Now.AddMinutes(120),
                signingCredentials: credentials
                );
            var encodedToken = new JwtSecurityTokenHandler().WriteToken(token);
            return encodedToken;
        }
        [Authorize]
        [HttpPost("Post")]
        public string Post()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            IList<Claim> claim = identity.Claims.ToList();
            var username = claim[0].Value;
            return "Welcome" + username;
        }
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Value1", "Value2", "Value3" };
        }
    }
}