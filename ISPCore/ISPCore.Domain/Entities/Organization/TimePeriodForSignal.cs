using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class TimePeriodForSignal : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public double UpToHours { get; set; }
        public int SignalSign { get; set; }

        public int Status { get; private set; }


        public TimePeriodForSignal() { }

        public TimePeriodForSignal(double upToHours,int signalSign)
        {
            UpToHours = upToHours;
            SignalSign = signalSign;
        }

        public void UpdateTimePeriodForSignal(double upToHours, int signalSign)
        {
            UpToHours = upToHours;
            SignalSign = signalSign;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
