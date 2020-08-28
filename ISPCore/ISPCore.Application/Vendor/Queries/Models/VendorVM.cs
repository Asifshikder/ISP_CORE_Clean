using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Vendor.Queries.Models
{
    public class VendorVM
    {
        public int Id { get; set; } 
        public string VendorName { get; set; }
        public string VendorAddress { get; set; }
        public string CompanyName { get; set; }
        public string VendorLogoName { get; set; }
        public byte[] VendorImageOriginalName { get; set; }
        public string VendorImagePath { get; set; }
        public string VendorContactPerson { get; set; }
        public string VendorEmail { get; set; }
    }
}
