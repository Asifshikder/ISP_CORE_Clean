using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class PurchaseDetails : BaseEntity, IHasId<int>, IAggregateRoot
    {
        //public int PurchaseDetailsID { get; set; }
        public int Id { get; private set; }
        public int PurchaseID { get; set; }
        public Purchase Purchase { get; set; }
        public int ItemID { get; set; }
        public Item Item { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public double Tax { get; set; }
        public bool HasWarrenty { get; set; }
        public DateTime? WarrentyStart { get; set; }
        public DateTime? WarrentyEnd { get; set; }
        public string Serial { get; set; }
        public int Status { get; private set; }

        public PurchaseDetails() { }

        public PurchaseDetails( int purchaseID ,int itemID ,double quantity, double price ,double tax, bool hasWarrenty , DateTime? warrentyStart,DateTime? warrentyEnd,string serial)
        {
            PurchaseID = purchaseID;
            ItemID = itemID;
            Quantity = quantity;
            Price = price;
            Tax = tax;
            HasWarrenty = hasWarrenty;
            WarrentyStart = warrentyStart;
            WarrentyEnd = warrentyEnd;
            Serial = serial;
        }

        public void UpdatePurchaseDetails(int purchaseID, int itemID, double quantity, double price, double tax, bool hasWarrenty, DateTime? warrentyStart, DateTime? warrentyEnd, string serial)
        {
            PurchaseID = purchaseID;
            ItemID = itemID;
            Quantity = quantity;
            Price = price;
            Tax = tax;
            HasWarrenty = hasWarrenty;
            WarrentyStart = warrentyStart;
            WarrentyEnd = warrentyEnd;
            Serial = serial;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
