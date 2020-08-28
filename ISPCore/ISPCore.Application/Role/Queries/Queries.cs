using ISPCore.Application.Role.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Role.Queries
{
    public static class Queries
    {
        public class GetRoleList : IRequest<List<RoleVM>>
        {
        }
        public class GetRole : IRequest<RoleVM>
        {
            public int Id { get; set; }
        }
    }
}
