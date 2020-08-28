using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.LoginViewModel.Command
{
    public static class Commands
    {
        public static class LoginViewModel
        {
            public class Create : IRequest<LoginViewModelCommandVM>
            {
                public string UserName { get; set; }
                public string Password { get; set; }
                public bool RememberMe { get; set; }
            }

            public class Update : IRequest<LoginViewModelCommandVM>
            {
                public int Id { get; set; }
                public string UserName { get; set; }
                public string Password { get; set; }
                public bool RememberMe { get; set; }
            }

            public class MarkAsDelete : IRequest<LoginViewModelCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
