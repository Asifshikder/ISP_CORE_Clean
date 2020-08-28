using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class IPPool : BaseEntity, IHasId<int>, IAggregateRoot
    {
        //public int IPPoolID { get; set; }
        public int Id { get; private set; }
        public string IPPoolName { get; set; }
        public string StartRange { get; set; }
        public string EndRange { get; set; }

        public int Status { get; private set; }

        public IPPool() { }

        public IPPool(string iPPoolName, string startRange, string endRange)
        {
            IPPoolName = iPPoolName;
            StartRange = startRange;
            EndRange = endRange;
        }

        public void UpdateIPPool(string iPPoolName, string startRange, string endRange)
        {
            IPPoolName = iPPoolName;
            StartRange = startRange;
            EndRange = endRange;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
