using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.TimePeriodForSignal.Command
{
    public static class Commands
    {
        public static class TimePeriodForSignal
        {
            public class Create : IRequest<TimePeriodForSignalCommandVM>
            {
                public double UpToHours { get; set; }
                public int SignalSign { get; set; }
            }

            public class Update : IRequest<TimePeriodForSignalCommandVM>
            {
                public int Id { get; set; }
                public double UpToHours { get; set; }
                public int SignalSign { get; set; }
            }

            public class MarkAsDelete : IRequest<TimePeriodForSignalCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
