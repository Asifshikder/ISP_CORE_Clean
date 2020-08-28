using ISPCore.Application.Client_Stock_StockDetails_ForDistribution.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Client_Stock_StockDetails_ForDistribution.Queries
{
    public static class Queries
    {
        public class GetClient_Stock_StockDetails_ForDistributionList : IRequest<List<Client_Stock_StockDetails_ForDistributionVM>>
        {
        }
        public class GetClient_Stock_StockDetails_ForDistribution : IRequest<Client_Stock_StockDetails_ForDistributionVM>
        {
            public int Id { get; set; }
        }
    }
}
