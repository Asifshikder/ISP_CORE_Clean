using ISPCore.Application.EmployeeVsWorkSchedule.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.EmployeeVsWorkSchedule.Queries
{
    public static class Queries
    {
        public class GetEmployeeVsWorkScheduleList : IRequest<List<EmployeeVsWorkScheduleVM>>
        {
        }
        public class GetEmployeeVsWorkSchedule : IRequest<EmployeeVsWorkScheduleVM>
        {
            public int Id { get; set; }
        }
    }
}
