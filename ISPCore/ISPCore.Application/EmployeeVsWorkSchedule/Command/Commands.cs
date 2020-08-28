using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.EmployeeVsWorkSchedule.Command
{
    public static class Commands
    {
        public static class EmployeeVsWorkSchedule
        {
            public class Create : IRequest<EmployeeVsWorkScheduleCommandVM>
            {
                public int DayID { get; set; }
                public int StartHour { get; set; }
                public int StartMinute { get; set; }
                public int RunHour { get; set; }
                public int RunMinute { get; set; }
                public int BreakStartHour { get; set; }
                public int BreakStartMinute { get; set; }
                public int BreakEndHour { get; set; }
                public int BreakEndMinute { get; set; }
                public int EmployeeID { get; set; }
            }

            public class Update : IRequest<EmployeeVsWorkScheduleCommandVM>
            {
                public int Id { get; set; }
                public int DayID { get; set; }
                public int StartHour { get; set; }
                public int StartMinute { get; set; }
                public int RunHour { get; set; }
                public int RunMinute { get; set; }
                public int BreakStartHour { get; set; }
                public int BreakStartMinute { get; set; }
                public int BreakEndHour { get; set; }
                public int BreakEndMinute { get; set; }
                public int EmployeeID { get; set; }
            }

            public class MarkAsDelete : IRequest<EmployeeVsWorkScheduleCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
