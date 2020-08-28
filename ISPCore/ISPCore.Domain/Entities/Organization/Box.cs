using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class Box : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public string BoxName { get; set; }
        public int? ResellerID { get; set; }
        public virtual Reseller Reseller { get; set; }
        public string BoxLocation { get; set; }
        public int Status { get; private set; }


        public Box() { }

        public Box(string boxName , int? resellerID,string boxLocation)
        {
            BoxName = boxName;
            ResellerID = resellerID;
            BoxLocation = boxLocation;
        }

        public void UpdateBox(string boxName, int? resellerID, string boxLocation)
        {
            BoxName = boxName;
            ResellerID = resellerID;
            BoxLocation = boxLocation;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
