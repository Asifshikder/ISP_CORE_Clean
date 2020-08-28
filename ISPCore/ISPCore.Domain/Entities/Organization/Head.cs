using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class Head : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public string HeadName { get; set; }
        public int HeadTypeID { get; set; }
        public int? ResellerID { get; set; }
        public virtual Reseller Reseller { get; set; }

        public int Status { get; private set; }

        public Head() { }

        public Head(string headName, int headTypeID, int? resellerID)
        {
            HeadName = headName;
            HeadTypeID = headTypeID;
            ResellerID = resellerID;
        }

        public void UpdateHead(string headName, int headTypeID, int? resellerID)
        {
            HeadName = headName;
            HeadTypeID = headTypeID;
            ResellerID = resellerID;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
