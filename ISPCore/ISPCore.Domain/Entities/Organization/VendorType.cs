using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class VendorType : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public string VendorTypeName { get; private set; }

        public int Status { get; private set; }


        public VendorType() { }

        public VendorType(string vendorTypeName)
        {
            VendorTypeName = vendorTypeName;
        }

        public void UpdateVendorType(string vendorTypeName)
        {
            VendorTypeName = vendorTypeName;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
