using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class Zone : BaseEntity, IHasId<int>, IAggregateRoot
    {
        //public int ZoneID { get; set; }
        public int Id { get; private set; }
        public string ZoneName { get; set; }
        public int? ResellerID { get; set; }
        public virtual Reseller Reseller { get; set; }

        public int Status { get; private set; }

        public Zone() { }

        public Zone(string zoneName,int? resellerID)
        {
            ZoneName = zoneName;
            ResellerID = resellerID;
        }

        public void UpdateZone(string zoneName, int? resellerID)
        {
            ZoneName = zoneName;
            ResellerID = resellerID;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
