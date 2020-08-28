using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.SecurityQuestion.Command
{
    public static class Commands
    {
        public static class SecurityQuestion
        {
            public class Create : IRequest<SecurityQuestionCommandVM>
            {
                public string SecurityQuestionName { get; set; }
            }

            public class Update : IRequest<SecurityQuestionCommandVM>
            {
                public int Id { get; set; }
                public string SecurityQuestionName { get; set; }
            }

            public class MarkAsDelete : IRequest<SecurityQuestionCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
