using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.DutyShift.Command
{
    public static class Commands
    {
        public static class DutyShift
        {
            public class Create : IRequest<DutyShiftCommandVM>
            {
                public int StartHour { get; set; }
                public int StartMinute { get; set; }
                public int EndHour { get; set; }
                public int EndMinute { get; set; }
            }

            public class Update : IRequest<DutyShiftCommandVM>
            {
                public int Id { get; set; }
                public int StartHour { get; set; }
                public int StartMinute { get; set; }
                public int EndHour { get; set; }
                public int EndMinute { get; set; }
            }

            public class MarkAsDelete : IRequest<DutyShiftCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
