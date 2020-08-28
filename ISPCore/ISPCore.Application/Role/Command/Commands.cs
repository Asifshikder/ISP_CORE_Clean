using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Role.Command
{
    public static class Commands
    {
        public static class Role
        {
            public class Create : IRequest<RoleCommandVM>
            {
                public string RoleName { get; set; }
            }

            public class Update : IRequest<RoleCommandVM>
            {
                public int Id { get; set; }
                public string RoleName { get; set; }
            }

            public class MarkAsDelete : IRequest<RoleCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
