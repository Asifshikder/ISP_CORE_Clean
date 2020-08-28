using Dapper;
using ISPCore.Application.ResellerPaymentDetailsHistory.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ResellerPaymentDetailsHistory.Queries
{
    public class GetResellerPaymentDetailsHistoryListQueryHandler : IRequestHandler<Queries.GetResellerPaymentDetailsHistoryList, List<ResellerPaymentDetailsHistoryVM>>
    {
        public GetResellerPaymentDetailsHistoryListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<ResellerPaymentDetailsHistoryVM>> Handle(Queries.GetResellerPaymentDetailsHistoryList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, ResellerPaymentID,ResellerID,ResellerPaymentGivenTypeID,ActionTypeID,LastAmount,PaymentAmount,DeleteTimeResellerAmount,PaymentYear,PaymentMonth,PaymentStatus,PaymentCheckOrAnySerial,CollectBy,ActiveBy,PaymentByID,PaymenReceivedDate" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<ResellerPaymentDetailsHistoryVM>(query);
            return data.ToList();
        }
    }
}
