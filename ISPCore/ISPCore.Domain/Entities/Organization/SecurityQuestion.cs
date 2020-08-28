using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class SecurityQuestion : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public string SecurityQuestionName { get; set; }

        public int Status { get; private set; }


        public SecurityQuestion() { }

        public SecurityQuestion(string securityQuestionName)
        {
            SecurityQuestionName = securityQuestionName;
        }

        public void UpdateSecurityQuestion(string securityQuestionName)
        {
            SecurityQuestionName = securityQuestionName;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
