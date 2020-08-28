using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.AttendanceType.Command
{
    public static class Commands
    {
        public static class AttendanceType
        {
            public class Create : IRequest<AttendanceTypeCommandVM>
            {
                public string AttendanceTypeName { get; set; }
            }

            public class Update : IRequest<AttendanceTypeCommandVM>
            {
                public int Id { get; set; }
                public string AttendanceTypeName { get; set; }
            }

            public class MarkAsDelete : IRequest<AttendanceTypeCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
