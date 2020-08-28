using Dapper;
using ISPCore.Application.Client_Stock_StockDetails.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Client_Stock_StockDetails.Queries
{
    public class GetClient_Stock_StockDetailsQueryHandler : IRequestHandler<Queries.GetClient_Stock_StockDetails, Client_Stock_StockDetailsVM>
    {
        public GetClient_Stock_StockDetailsQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<Client_Stock_StockDetailsVM> Handle(Queries.GetClient_Stock_StockDetails request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetClient_Stock_StockDetailsById({request.Client_Stock_StockDetailsId})";
            var query = $"SELECT * from Client_Stock_StockDetails where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<Client_Stock_StockDetailsVM>(query);
            return data;
        }
    }
}
