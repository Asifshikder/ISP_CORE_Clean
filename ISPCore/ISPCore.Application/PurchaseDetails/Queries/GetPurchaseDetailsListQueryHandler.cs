using Dapper;
using ISPCore.Application.PurchaseDetails.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.PurchaseDetails.Queries
{
    public class GetPurchaseDetailsListQueryHandler : IRequestHandler<Queries.GetPurchaseDetailsList, List<PurchaseDetailsVM>>
    {
        public GetPurchaseDetailsListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<PurchaseDetailsVM>> Handle(Queries.GetPurchaseDetailsList request, CancellationToken cancellationToken)
        {
            var query = $"select Id ,PurchaseID,ItemID,Quantity,Price,Tax,HasWarrenty,WarrentyStart,WarrentyEnd,Serial" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<PurchaseDetailsVM>(query);
            return data.ToList();
        }
    }
}
