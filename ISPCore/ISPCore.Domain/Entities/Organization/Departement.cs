using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class Department : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public string DepartmentName { get; private set; }

        public int Status { get; private set; }


        public Department() { }

        public Department(string departmentName)
        {
            DepartmentName = departmentName;
        }

        public void UpdateDepartement(string departmentName)
        {
            DepartmentName = departmentName;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
