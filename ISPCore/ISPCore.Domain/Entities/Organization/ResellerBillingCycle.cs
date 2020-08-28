using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class ResellerBillingCycle : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public int Day { get; set; }
        public int Status { get; private set; }


        public ResellerBillingCycle() { }

        public ResellerBillingCycle(int day)
        {
            Day = day;
        }

        public void UpdateResellerBillingCycle(int day)
        {
            Day = day;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
