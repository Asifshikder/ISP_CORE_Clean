using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class Vendor : BaseEntity, IHasId<int>, IAggregateRoot
    {
        //public int VendorID { get; set; }
        public int Id { get; private set; }
        public string VendorName { get; set; }
        public string VendorAddress { get; set; }
        public string CompanyName { get; set; }
        public string VendorLogoName { get; set; }
        public byte[] VendorImageOriginal { get; set; }
        public string VendorImagePath { get; set; }
        public string VendorContactPerson { get; set; }
        public string VendorEmail { get; set; }

        public int Status { get; private set; }

        public Vendor() { }

        public Vendor(string vendorName, string vendorAddress, string companyName,string vendorLogoName,byte[] vendorImageOriginal,string vendorImagePath,string vendorContactPerson,string vendorEmail)
        {
            VendorName = vendorName;
            VendorAddress = vendorAddress;
            CompanyName = companyName;
            VendorLogoName = vendorLogoName;
            VendorImageOriginal = vendorImageOriginal;
            VendorImagePath = vendorImagePath;
            VendorContactPerson = vendorContactPerson;
            VendorEmail = vendorEmail;
        }

        public void UpdateVendor(string vendorName, string vendorAddress, string companyName, string vendorLogoName, byte[] vendorImageOriginal, string vendorImagePath, string vendorContactPerson, string vendorEmail)
        {
            VendorName = vendorName;
            VendorAddress = vendorAddress;
            CompanyName = companyName;
            VendorLogoName = vendorLogoName;
            VendorImageOriginal = vendorImageOriginal;
            VendorImagePath = vendorImagePath;
            VendorContactPerson = vendorContactPerson;
            VendorEmail = vendorEmail;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
