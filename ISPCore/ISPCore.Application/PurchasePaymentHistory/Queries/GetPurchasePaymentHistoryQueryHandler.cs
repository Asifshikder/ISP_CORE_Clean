using Dapper;
using ISPCore.Application.PurchasePaymentHistory.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.PurchasePaymentHistory.Queries
{
    public class GetPurchasePaymentHistoryQueryHandler : IRequestHandler<Queries.GetPurchasePaymentHistory, PurchasePaymentHistoryVM>
    {
        public GetPurchasePaymentHistoryQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<PurchasePaymentHistoryVM> Handle(Queries.GetPurchasePaymentHistory request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetPurchasePaymentHistoryById({request.PurchasePaymentHistoryId})";
            var query = $"SELECT * from PurchasePaymentHistory where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<PurchasePaymentHistoryVM>(query);
            return data;
        }
    }
}
