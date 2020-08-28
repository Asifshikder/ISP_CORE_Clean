using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class StockDetails : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        //public int StockDetailsID { get; set; }
        public int StockID { get; set; }
        public virtual Stock Stock { get; set; }
        public int? BrandID { get; set; }
        public virtual Brand Brand { get; set; }
        public int SectionID { get; set; }
        public virtual Section Section { get; set; }
        public int? SupplierID { get; set; }
        public virtual Supplier Supplier { get; set; }
        public string SupplierInvoice { get; set; }
        public string Serial { get; set; }
        public string BarCode { get; set; }
        public int ProductStatusID { get; set; }
        public virtual ProductStatus ProductStatus { get; set; }
        public bool WarrentyProduct { get; set; }

        public int Status { get; private set; }


        public StockDetails() { }

        public StockDetails(int stockID,int? brandID,int sectionID, int? supplierID,string supplierInvoice,string serial,string barCode,int  productStatusID, bool warrentyProduct)
        {
            StockID = stockID;
            BrandID = brandID;
            SectionID = sectionID;
            SupplierID = supplierID;
            SupplierInvoice = supplierInvoice;
            Serial = serial;
            BarCode = barCode;
            ProductStatusID = productStatusID;
            WarrentyProduct = warrentyProduct;
        }

        public void UpdateStockDetails(int stockID, int? brandID, int sectionID, int? supplierID, string supplierInvoice, string serial, string barCode, int productStatusID, bool warrentyProduct)
        {
            StockID = stockID;
            BrandID = brandID;
            SectionID = sectionID;
            SupplierID = supplierID;
            SupplierInvoice = supplierInvoice;
            Serial = serial;
            BarCode = barCode;
            ProductStatusID = productStatusID;
            WarrentyProduct = warrentyProduct;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
