using ISPCore.Application.Brand.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Brand.Queries
{
    public static class Queries
    {
        public class GetBrandList : IRequest<List<BrandVM>>
        {
        }
        public class GetBrand : IRequest<BrandVM>
        {
            public int Id { get; set; }
        }
    }
}
