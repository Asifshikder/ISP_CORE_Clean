using Dapper;
using ISPCore.Application.PayementHistory.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.PayementHistory.Queries
{
    public class GetPayementHistoryListQueryHandler : IRequestHandler<Queries.GetPayementHistoryList, List<PayementHistoryVM>>
    {
        public GetPayementHistoryListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<PayementHistoryVM>> Handle(Queries.GetPayementHistoryList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, TransactionID,ClientDetailsID,EmployeeID,ResellerID,CollectByID,PaidAmount,ResetNo,AdvancePaymentID,PaymentByID,NormalPayment,DiscountPayment,PaymentFromWhichPage,BillAcceptBy,AcceptStatus" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<PayementHistoryVM>(query);
            return data.ToList();
        }
    }
}
