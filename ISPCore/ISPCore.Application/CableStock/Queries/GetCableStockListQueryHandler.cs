using Dapper;
using ISPCore.Application.CableStock.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.CableStock.Queries
{
    public class GetCableStockListQueryHandler : IRequestHandler<Queries.GetCableStockList, List<CableStockVM>>
    {
        public GetCableStockListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<CableStockVM>> Handle(Queries.GetCableStockList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, request.CableTypeID,BrandID,SupplierID,SupplierInvoice,FromReading,ToReading,CableUnitID,CableBoxName,CableQuantity,UsedQuantityFromThisBox,TotallyUsed,EmployeeID,IndicatorStatus" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<CableStockVM>(query);
            return data.ToList();
        }
    }
}
