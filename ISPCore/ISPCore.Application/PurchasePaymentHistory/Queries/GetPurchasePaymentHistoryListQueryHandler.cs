using Dapper;
using ISPCore.Application.PurchasePaymentHistory.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.PurchasePaymentHistory.Queries
{
    public class GetPurchasePaymentHistoryListQueryHandler : IRequestHandler<Queries.GetPurchasePaymentHistoryList, List<PurchasePaymentHistoryVM>>
    {
        public GetPurchasePaymentHistoryListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<PurchasePaymentHistoryVM>> Handle(Queries.GetPurchasePaymentHistoryList request, CancellationToken cancellationToken)
        {
            var query = $"select Id,  PurchaseID, AccountListID, PaymentByID, PurchasePaymentDate, CheckNo, CheckName, CheckPath, CheckImageBytes, Description, PaymentAmount, PaymentPaidBy" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<PurchasePaymentHistoryVM>(query);
            return data.ToList();
        }
    }
}
