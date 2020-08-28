using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.DutyShift.Queries.Models
{
    public class DutyShiftVM
    {
        public int Id { get; set; } 
        public string DutyShiftName { get; set; }
        public int StartHour { get; set; }
        public int StartMinute { get; set; }
        public int EndHour { get; set; }
        public int EndMinute { get; set; }
    }
}
