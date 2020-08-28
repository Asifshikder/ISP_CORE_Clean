using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.TimePeriodForSignal.Queries.Models
{
    public class TimePeriodForSignalVM
    {
        public int Id { get; set; }
        public double UpToHours { get; set; }
        public int SignalSign { get; set; }
    }
}
