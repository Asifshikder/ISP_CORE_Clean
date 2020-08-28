using ISPCore.Application.BandwithResellerGivenItem.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.BandwithResellerGivenItem.Queries
{
    public static class Queries
    {
        public class GetBandwithResellerGivenItemList : IRequest<List<BandwithResellerGivenItemVM>>
        {
        }
        public class GetBandwithResellerGivenItem : IRequest<BandwithResellerGivenItemVM>
        {
            public int Id { get; set; }
        }
    }
}
