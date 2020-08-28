using ISPCore.Application.EmployeeLeaveHistory.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.EmployeeLeaveHistory.Queries
{
    public static class Queries
    {
        public class GetEmployeeLeaveHistoryList : IRequest<List<EmployeeLeaveHistoryVM>>
        {
        }
        public class GetEmployeeLeaveHistory : IRequest<EmployeeLeaveHistoryVM>
        {
            public int Id { get; set; }
        }
    }
}
