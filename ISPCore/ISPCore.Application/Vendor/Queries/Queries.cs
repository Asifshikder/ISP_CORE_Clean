using ISPCore.Application.Vendor.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Vendor.Queries
{
    public static class Queries
    {
        public class GetVendorList : IRequest<List<VendorVM>>
        {
        }
        public class GetVendor : IRequest<VendorVM>
        {
            public int Id { get; set; }
        }
    }
}
