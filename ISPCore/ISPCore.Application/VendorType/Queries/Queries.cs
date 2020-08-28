using ISPCore.Application.VendorType.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.VendorType.Queries
{
    public static class Queries
    {
        public class GetVendorTypeList : IRequest<List<VendorTypeVM>>
        {
        }
        public class GetVendorType : IRequest<VendorTypeVM>
        {
            public int Id { get; set; }
        }
    }
}
