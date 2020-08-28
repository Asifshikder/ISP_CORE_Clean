using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class Stock : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public int ItemID { get; set; }
        public virtual Item Item { get; set; }
        public int? Quantity { get; set; }
        public int Status { get; private set; }


        public Stock() { }

        public Stock(int itemID,int? quantity)
        {
            ItemID = itemID;
            Quantity = quantity;
        }

        public void UpdateStock(int itemID, int? quantity)
        {
            ItemID = itemID;
            Quantity = quantity;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
