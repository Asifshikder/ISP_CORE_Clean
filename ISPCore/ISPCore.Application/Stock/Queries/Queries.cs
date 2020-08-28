using ISPCore.Application.Stock.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Stock.Queries
{
    public static class Queries
    {
        public class GetStockList : IRequest<List<StockVM>>
        {
        }
        public class GetStock : IRequest<StockVM>
        {
            public int Id { get; set; }
        }
    }
}
