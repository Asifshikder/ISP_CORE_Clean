using Dapper;
using ISPCore.Application.ResellerPaymentDetailsHistory.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ResellerPaymentDetailsHistory.Queries
{
    public class GetResellerPaymentDetailsHistoryQueryHandler : IRequestHandler<Queries.GetResellerPaymentDetailsHistory, ResellerPaymentDetailsHistoryVM>
    {
        public GetResellerPaymentDetailsHistoryQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<ResellerPaymentDetailsHistoryVM> Handle(Queries.GetResellerPaymentDetailsHistory request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetResellerPaymentDetailsHistoryById({request.ResellerPaymentDetailsHistoryId})";
            var query = $"SELECT * from ResellerPaymentDetailsHistory where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<ResellerPaymentDetailsHistoryVM>(query);
            return data;
        }
    }
}
