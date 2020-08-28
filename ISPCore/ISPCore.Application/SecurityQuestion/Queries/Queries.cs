using ISPCore.Application.SecurityQuestion.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.SecurityQuestion.Queries
{
    public static class Queries
    {
        public class GetSecurityQuestionList : IRequest<List<SecurityQuestionVM>>
        {
        }
        public class GetSecurityQuestion : IRequest<SecurityQuestionVM>
        {
            public int Id { get; set; }
        }
    }
}
