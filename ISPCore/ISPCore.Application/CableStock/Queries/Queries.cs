using ISPCore.Application.CableStock.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.CableStock.Queries
{
    public static class Queries
    {
        public class GetCableStockList : IRequest<List<CableStockVM>>
        {
        }
        public class GetCableStock : IRequest<CableStockVM>
        {
            public int Id { get; set; }
        }
    }
}
