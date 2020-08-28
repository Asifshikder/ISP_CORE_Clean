using ISPCore.Application.Client_Stock_StockDetails.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Client_Stock_StockDetails.Queries
{
    public static class Queries
    {
        public class GetClient_Stock_StockDetailsList : IRequest<List<Client_Stock_StockDetailsVM>>
        {
        }
        public class GetClient_Stock_StockDetails : IRequest<Client_Stock_StockDetailsVM>
        {
            public int Id { get; set; }
        }
    }
}
