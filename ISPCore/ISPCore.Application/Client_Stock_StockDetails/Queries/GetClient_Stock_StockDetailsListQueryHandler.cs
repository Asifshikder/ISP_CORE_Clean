using Dapper;
using ISPCore.Application.Client_Stock_StockDetails.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Client_Stock_StockDetails.Queries
{
    public class GetClient_Stock_StockDetailsListQueryHandler : IRequestHandler<Queries.GetClient_Stock_StockDetailsList, List<Client_Stock_StockDetailsVM>>
    {
        public GetClient_Stock_StockDetailsListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<Client_Stock_StockDetailsVM>> Handle(Queries.GetClient_Stock_StockDetailsList request, CancellationToken cancellationToken)
        {
            var query = $"select Id,  StockID, StockDetailsID, ItemID, ItemName, BrandID, BrandName, SupplierID, SupplierName, SupplierInvoice, Serial, WarrentyProduct" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<Client_Stock_StockDetailsVM>(query);
            return data.ToList();
        }
    }
}
