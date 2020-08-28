using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.UserRightPermission.Queries.Models
{
    public class UserRightPermissionVM
    {
        public int Id { get; set; } 
        public string UserRightPermissionName { get; set; }
        public string UserRightPermissionDescription { get; set; }
        public string UserRightPermissionDetails { get; set; }
    }
}
