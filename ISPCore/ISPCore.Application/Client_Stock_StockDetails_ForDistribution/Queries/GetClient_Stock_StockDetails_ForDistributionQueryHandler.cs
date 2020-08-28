using Dapper;
using ISPCore.Application.Client_Stock_StockDetails_ForDistribution.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Client_Stock_StockDetails_ForDistribution.Queries
{
    public class GetClient_Stock_StockDetails_ForDistributionQueryHandler : IRequestHandler<Queries.GetClient_Stock_StockDetails_ForDistribution, Client_Stock_StockDetails_ForDistributionVM>
    {
        public GetClient_Stock_StockDetails_ForDistributionQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<Client_Stock_StockDetails_ForDistributionVM> Handle(Queries.GetClient_Stock_StockDetails_ForDistribution request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetClient_Stock_StockDetails_ForDistributionById({request.Client_Stock_StockDetails_ForDistributionId})";
            var query = $"SELECT * from Client_Stock_StockDetails_ForDistribution where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<Client_Stock_StockDetails_ForDistributionVM>(query);
            return data;
        }
    }
}
