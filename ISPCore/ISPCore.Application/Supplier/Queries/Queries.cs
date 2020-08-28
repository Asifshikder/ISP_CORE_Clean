using ISPCore.Application.Supplier.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Supplier.Queries
{
    public static class Queries
    {
        public class GetSupplierList : IRequest<List<SupplierVM>>
        {
        }
        public class GetSupplier : IRequest<SupplierVM>
        {
            public int Id { get; set; }
        }
    }
}
