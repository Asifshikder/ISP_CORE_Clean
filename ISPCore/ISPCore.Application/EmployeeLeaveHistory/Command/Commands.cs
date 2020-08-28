using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.EmployeeLeaveHistory.Command
{
    public static class Commands
    {
        public static class EmployeeLeaveHistory
        {
            public class Create : IRequest<EmployeeLeaveHistoryCommandVM>
            {

                public int EmployeeID { get; set; }
                public string Reason { get; set; }
                public int LeaveSalaryTypeID { get; set; }
                public DateTime StartDate { get; set; }
                public DateTime EndDate { get; set; }
            }

            public class Update : IRequest<EmployeeLeaveHistoryCommandVM>
            {
                public int Id { get; set; }

                public int EmployeeID { get; set; }
                public string Reason { get; set; }
                public int LeaveSalaryTypeID { get; set; }
                public DateTime StartDate { get; set; }
                public DateTime EndDate { get; set; }
            }

            public class MarkAsDelete : IRequest<EmployeeLeaveHistoryCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
