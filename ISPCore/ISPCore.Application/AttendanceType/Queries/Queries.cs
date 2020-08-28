using ISPCore.Application.AttendanceType.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.AttendanceType.Queries
{
    public static class Queries
    {
        public class GetAttendanceTypeList : IRequest<List<AttendanceTypeVM>>
        {
        }
        public class GetAttendanceType : IRequest<AttendanceTypeVM>
        {
            public int Id { get; set; }
        }
    }
}
