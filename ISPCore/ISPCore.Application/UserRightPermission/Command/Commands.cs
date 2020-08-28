using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.UserRightPermission.Command
{
    public static class Commands
    {
        public static class UserRightPermission
        {
            public class Create : IRequest<UserRightPermissionCommandVM>
            {
                public string UserRightPermissionName { get; set; }

                public string UserRightPermissionDescription { get; set; }
                public string UserRightPermissionDetails { get; set; }
            }

            public class Update : IRequest<UserRightPermissionCommandVM>
            {
                public int Id { get; set; }
                public string UserRightPermissionName { get; set; }

                public string UserRightPermissionDescription { get; set; }
                public string UserRightPermissionDetails { get; set; }
            }

            public class MarkAsDelete : IRequest<UserRightPermissionCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
