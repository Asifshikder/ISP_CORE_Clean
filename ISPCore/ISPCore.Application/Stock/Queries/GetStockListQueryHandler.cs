using Dapper;
using ISPCore.Application.Stock.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Stock.Queries
{
    public class GetStockListQueryHandler : IRequestHandler<Queries.GetStockList, List<StockVM>>
    {
        public GetStockListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<StockVM>> Handle(Queries.GetStockList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, ItemID,Quantity" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<StockVM>(query);
            return data.ToList();
        }
    }
}
