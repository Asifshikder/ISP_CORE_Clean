using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class CableStock : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public int CableTypeID { get; set; }
        public virtual CableType CableType { get; set; }
        public int? BrandID { get; set; }
        public virtual Brand Brand { get; set; }
        public int? SupplierID { get; set; }
        public virtual Supplier Supplier { get; set; }
        public string SupplierInvoice { get; set; }
        public int FromReading { get; set; }
        public int ToReading { get; set; }
        public int CableUnitID { get; set; }
        public virtual CableUnit CableUnit { get; set; }
        public string CableBoxName { get; set; }
        public int CableQuantity { get; set; }
        public int UsedQuantityFromThisBox { get; set; }
        public int? TotallyUsed { get; set; }
        public int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }
        public int IndicatorStatus { get; set; }

        public int Status { get; private set; }


        public CableStock() { }

        public CableStock(  int cableTypeID,int? brandID,int? supplierID,string supplierInvoice,int fromReading,int toReading ,
            int cableUnitID,string cableBoxName, int cableQuantity, int usedQuantityFromThisBox, int? totallyUsed , int employeeID , int indicatorStatus )
        {
            CableTypeID = cableTypeID;
            BrandID = brandID;
            SupplierID = supplierID;
            SupplierInvoice = supplierInvoice;
            FromReading = fromReading;
            ToReading = ToReading;
            CableUnitID = cableUnitID;
            CableBoxName = cableBoxName;
            CableQuantity = cableQuantity;
            UsedQuantityFromThisBox = usedQuantityFromThisBox;
            TotallyUsed = totallyUsed;
            EmployeeID = employeeID;
            IndicatorStatus = indicatorStatus;
        }

        public void UpdateCableStock(int cableTypeID, int? brandID, int? supplierID, string supplierInvoice, int fromReading, int toReading,
            int cableUnitID, string cableBoxName, int cableQuantity, int usedQuantityFromThisBox, int? totallyUsed, int employeeID, int indicatorStatus)
        {
            CableTypeID = cableTypeID;
            BrandID = brandID;
            SupplierID = supplierID;
            SupplierInvoice = supplierInvoice;
            FromReading = fromReading;
            ToReading = ToReading;
            CableUnitID = cableUnitID;
            CableBoxName = cableBoxName;
            CableQuantity = cableQuantity;
            UsedQuantityFromThisBox = usedQuantityFromThisBox;
            TotallyUsed = totallyUsed;
            EmployeeID = employeeID;
            IndicatorStatus = indicatorStatus;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
