using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class Item : BaseEntity, IHasId<int>, IAggregateRoot
    {
        //public int ItemID { get; set; }
        public int Id { get; private set; }
        public string ItemName { get; set; }
        public int? ItemFor { get; set; }
        public string ItemCode { get; set; }

        public int Status { get; private set; }

        public Item() { }

        public Item(string itemName,int? itemFor, string itemCode)
        {
            ItemName = itemName;
            ItemFor = itemFor;
            ItemCode = itemCode;
        }

        public void UpdateItem(string itemName, int? itemFor, string itemCode)
        {
            ItemName = itemName;
            ItemFor = itemFor;
            ItemCode = itemCode;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
