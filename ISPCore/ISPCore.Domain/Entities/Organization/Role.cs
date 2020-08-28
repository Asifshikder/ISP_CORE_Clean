using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class Role : BaseEntity, IHasId<int>, IAggregateRoot
    {
        //public int RoleID { get; set; }
        public int Id { get; private set; }
        public string RoleName { get; set; }

        public int Status { get; private set; }

        public Role() { }

        public Role(string roleName)
        {
            RoleName = roleName;
        }

        public void UpdateRole(string roleName)
        {
            RoleName = roleName;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
