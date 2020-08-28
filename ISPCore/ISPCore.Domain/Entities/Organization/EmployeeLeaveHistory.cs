using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class EmployeeLeaveHistory : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }
        public string Reason { get; set; }
        public int LeaveSalaryTypeID { get; set; }
        public virtual LeaveSalaryType LeaveSalaryType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int Status { get; private set; }


        public EmployeeLeaveHistory() { }

        public EmployeeLeaveHistory(int employeeID,string reason,int leaveSalaryTypeID,DateTime startDate,DateTime endDate)
        {
            EmployeeID = employeeID;
            Reason = reason;
            LeaveSalaryTypeID = leaveSalaryTypeID;
            StartDate = startDate;
            EndDate = endDate;
        }

        public void UpdateEmployeeLeaveHistory(int employeeID, string reason, int leaveSalaryTypeID, DateTime startDate, DateTime endDate)
        {
            EmployeeID = employeeID;
            Reason = reason;
            LeaveSalaryTypeID = leaveSalaryTypeID;
            StartDate = startDate;
            EndDate = endDate;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
