using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class DistributionReason : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public string DistributionReasonName { get; private set; }

        public int Status { get; private set; }


        public DistributionReason() { }

        public DistributionReason(string distributionReasonName)
        {
            DistributionReasonName = distributionReasonName;
        }

        public void UpdateDistributionReason(string distributionReasonName)
        {
            DistributionReasonName = distributionReasonName;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
