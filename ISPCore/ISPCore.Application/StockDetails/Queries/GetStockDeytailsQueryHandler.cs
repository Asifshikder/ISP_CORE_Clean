using Dapper;
using ISPCore.Application.StockDetails.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.StockDetails.Queries
{
    public class GetStockDetailsQueryHandler : IRequestHandler<Queries.GetStockDetails, StockDetailsVM>
    {
        public GetStockDetailsQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<StockDetailsVM> Handle(Queries.GetStockDetails request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetStockDetailsById({request.StockDetailsId})";
            var query = $"SELECT * from StockDetails where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<StockDetailsVM>(query);
            return data;
        }
    }
}
