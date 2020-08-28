using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class LoginViewModel : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public int Status { get; private set; }


        public LoginViewModel() { }

        public LoginViewModel(string userName ,string password ,bool rememberMe)
        {
            UserName = userName;
            Password = password;
            RememberMe = rememberMe;
        }

        public void UpdateLoginViewModel(string userName, string password, bool rememberMe)
        {
            UserName = userName;
            Password = password;
            RememberMe = rememberMe;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
