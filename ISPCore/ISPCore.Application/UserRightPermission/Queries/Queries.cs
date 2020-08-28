using ISPCore.Application.UserRightPermission.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.UserRightPermission.Queries
{
    public static class Queries
    {
        public class GetUserRightPermissionList : IRequest<List<UserRightPermissionVM>>
        {
        }
        public class GetUserRightPermission : IRequest<UserRightPermissionVM>
        {
            public int Id { get; set; }
        }
    }
}
