using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class Client_Stock_StockDetails: BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public int StockID { get; set; }
        public int StockDetailsID { get; set; }
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public int BrandID { get; set; }
        public string BrandName { get; set; }
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string SupplierInvoice { get; set; }
        public string Serial { get; set; }
        public bool WarrentyProduct { get; set; }

        public int Status { get; private set; }


        public Client_Stock_StockDetails() { }

        public Client_Stock_StockDetails(int stockID, int stockDetailsID,int itemID, string itemName, int brandID, string brandName, int supplierID,
            string supplierName, string supplierInvoice, string serial, bool warrentyProduct)
        {
            StockID = stockID;
            StockDetailsID = stockDetailsID;
            ItemID = itemID;
            ItemName = itemName;
            BrandName = brandName;
            BrandID = brandID;
            SupplierID = supplierID;
            SupplierName = supplierName;
            SupplierInvoice = supplierInvoice;
            Serial = serial;
            WarrentyProduct = warrentyProduct;
        }

        public void UpdateClient_Stock_StockDetails(int stockID, int stockDetailsID, int itemID, string itemName, int brandID, string brandName, int supplierID,
            string supplierName, string supplierInvoice, string serial, bool warrentyProduct)
        {
            StockID = stockID;
            StockDetailsID = stockDetailsID;
            ItemID = itemID;
            ItemName = itemName;
            BrandName = brandName;
            BrandID = brandID;
            SupplierID = supplierID;
            SupplierName = supplierName;
            SupplierInvoice = supplierInvoice;
            Serial = serial;
            WarrentyProduct = warrentyProduct;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
