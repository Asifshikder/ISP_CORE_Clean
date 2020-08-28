using ISPCore.Application.ProductStatus.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ProductStatus.Queries
{
    public static class Queries
    {
        public class GetProductStatusList : IRequest<List<ProductStatusVM>>
        {
        }
        public class GetProductStatus : IRequest<ProductStatusVM>
        {
            public int Id { get; set; }
        }
    }
}
