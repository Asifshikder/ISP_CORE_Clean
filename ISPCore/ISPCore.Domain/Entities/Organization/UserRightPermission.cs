using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
   public class UserRightPermission : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public string UserRightPermissionName { get; set; }
        public string UserRightPermissionDescription { get; set; }
        public string UserRightPermissionDetails { get; set; }

        public int Status { get; private set; }

        public UserRightPermission() { }

        public UserRightPermission(string userRightPermissionName, string userRightPermissionDetails, string userRightPermissionDescription)
        {
            UserRightPermissionName = userRightPermissionName;
            UserRightPermissionDescription = userRightPermissionDescription;
            UserRightPermissionDetails = userRightPermissionDetails;
        }

        public void UpdateUserRightPermission(string userRightPermissionName, string userRightPermissionDetails, string userRightPermissionDescription)
        {
            UserRightPermissionName = userRightPermissionName;
            UserRightPermissionDescription = userRightPermissionDescription;
            UserRightPermissionDetails = userRightPermissionDetails;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
