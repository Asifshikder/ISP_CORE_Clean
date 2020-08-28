using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.SecurityQuestion.Command
{
    public class SecurityQuestionCommandVM
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public string Message { get; set; }
    }
}
