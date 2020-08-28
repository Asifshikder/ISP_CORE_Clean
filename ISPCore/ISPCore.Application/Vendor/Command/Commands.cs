using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Vendor.Command
{
    public static class Commands
    {
        public static class Vendor
        {
            public class Create : IRequest<VendorCommandVM>
            {
                public string VendorName { get; set; }
                public string VendorAddress { get; set; }
                public string CompanyName { get; set; }
                public string VendorLogoName { get; set; }
                public byte[] VendorImageOriginal{ get; set; }
                public string VendorImagePath { get; set; }
                public string VendorContactPerson { get; set; }
                public string VendorEmail { get; set; }
            }

            public class Update : IRequest<VendorCommandVM>
            {
                public int Id { get; set; }
                public string VendorName { get; set; }
                public string VendorAddress { get; set; }
                public string CompanyName { get; set; }
                public string VendorLogoName { get; set; }
                public byte[] VendorImageOriginal { get; set; }
                public string VendorImagePath { get; set; }
                public string VendorContactPerson { get; set; }
                public string VendorEmail { get; set; }
            }

            public class MarkAsDelete : IRequest<VendorCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
