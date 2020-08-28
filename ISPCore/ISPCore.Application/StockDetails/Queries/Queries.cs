using ISPCore.Application.StockDetails.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.StockDetails.Queries
{
    public static class Queries
    {
        public class GetStockDetailsList : IRequest<List<StockDetailsVM>>
        {
        }
        public class GetStockDetails : IRequest<StockDetailsVM>
        {
            public int Id { get; set; }
        }
    }
}
