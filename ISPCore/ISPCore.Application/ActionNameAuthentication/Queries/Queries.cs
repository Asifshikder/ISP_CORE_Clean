using ISPCore.Application.ActionNameAuthentication.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ActionNameAuthentication.Queries
{
    public static class Queries
    {
        public class GetActionNameAuthenticationList : IRequest<List<ActionNameAuthenticationVM>>
        {
        }
        public class GetActionNameAuthentication : IRequest<ActionNameAuthenticationVM>
        {
            public int Id { get; set; }
        }
    }
}
