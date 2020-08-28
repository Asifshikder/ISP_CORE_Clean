using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class LeaveSalaryType : BaseEntity, IHasId<int>, IAggregateRoot
    {
        //public int LeaveSalaryTypeID { get; set; }
        public int Id { get; private set; }
        public string LeaveSalaryTypeName { get; set; }
        public decimal Percentage { get; set; }

        public int Status { get; private set; }

        public LeaveSalaryType() { }

        public LeaveSalaryType(string leaveTypeName, decimal percentage)
        {
            LeaveSalaryTypeName = leaveTypeName;
            Percentage = percentage;
        }

        public void UpdateLeaveSalaryType(string leaveTypeName, decimal percentage)
        {
            LeaveSalaryTypeName = leaveTypeName;
            Percentage = percentage;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
