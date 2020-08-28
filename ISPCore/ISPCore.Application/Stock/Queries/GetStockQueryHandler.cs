using Dapper;
using ISPCore.Application.Stock.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Stock.Queries
{
    public class GetStockQueryHandler : IRequestHandler<Queries.GetStock, StockVM>
    {
        public GetStockQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<StockVM> Handle(Queries.GetStock request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetStockById({request.StockId})";
            var query = $"SELECT * from Stock where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<StockVM>(query);
            return data;
        }
    }
}
