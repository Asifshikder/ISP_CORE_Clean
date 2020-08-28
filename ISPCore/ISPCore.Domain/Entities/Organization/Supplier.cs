using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class Supplier : BaseEntity, IHasId<int>, IAggregateRoot
    {
        //public int SupplierID { get; set; }
        public int Id { get; private set; }
        public string SupplierName { get; set; }
        public string SupplierAddress { get; set; }
        public int Status { get; private set; }

        public Supplier() { }

        public Supplier(string supplierName, string supplierAddress)
        {
            SupplierName = supplierName;
            SupplierAddress = supplierAddress;
        }

        public void UpdateSupplier(string supplierName, string supplierAddress)
        {
            SupplierName = supplierName;
            SupplierAddress = supplierAddress;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
