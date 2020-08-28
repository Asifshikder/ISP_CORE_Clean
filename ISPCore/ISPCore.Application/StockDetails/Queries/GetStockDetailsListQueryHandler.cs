using Dapper;
using ISPCore.Application.StockDetails.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.StockDetails.Queries
{
    public class GetStockDetailsListQueryHandler : IRequestHandler<Queries.GetStockDetailsList, List<StockDetailsVM>>
    {
        public GetStockDetailsListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<StockDetailsVM>> Handle(Queries.GetStockDetailsList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, StockID,BrandID,SectionID,SupplierID,SupplierInvoice,Serial,BarCode,ProductStatusID,WarrentyProduct" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<StockDetailsVM>(query);
            return data.ToList();
        }
    }
}
