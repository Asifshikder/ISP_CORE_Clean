using Dapper;
using ISPCore.Application.Purchase.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Purchase.Queries
{
    public class GetPurchaseQueryHandler : IRequestHandler<Queries.GetPurchase, PurchaseVM>
    {
        public GetPurchaseQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<PurchaseVM> Handle(Queries.GetPurchase request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetPurchaseById({request.PurchaseId})";
            var query = $"SELECT * from Purchase where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<PurchaseVM>(query);
            return data;
        }
    }
}
