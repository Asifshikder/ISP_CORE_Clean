using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class DutyShift : BaseEntity, IHasId<int>, IAggregateRoot
    {
        //public int DutyShiftID { get; set; }
        public int Id { get; private set; }
        public int StartHour { get; set; }
        public int StartMinute { get; set; }
        public int EndHour { get; set; }
        public int EndMinute { get; set; }

        public int Status { get; private set; }

        public DutyShift() { }

        public DutyShift(int startHour,int startMinute,int endHour, int endMinute)
        {
            StartHour = startHour;
            StartMinute = startMinute;
            EndHour = endHour;
            EndMinute = endMinute;
        }

        public void UpdateDutyShift(int startHour, int startMinute, int endHour, int endMinute)
        {
            StartHour = startHour;
            StartMinute = startMinute;
            EndHour = endHour;
            EndMinute = endMinute;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
