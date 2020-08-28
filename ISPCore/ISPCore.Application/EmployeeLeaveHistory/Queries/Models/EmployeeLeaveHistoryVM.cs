using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.EmployeeLeaveHistory.Queries.Models
{
    public class EmployeeLeaveHistoryVM
    {
        public int Id { get; set; }
        public int EmployeeID { get; set; }
        public string Reason { get; set; }
        public int LeaveSalaryTypeID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
