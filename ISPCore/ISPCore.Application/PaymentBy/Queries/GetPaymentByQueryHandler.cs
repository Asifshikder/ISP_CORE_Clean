using Dapper;
using ISPCore.Application.PaymentBy.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.PaymentBy.Queries
{
    public class GetPaymentByQueryHandler : IRequestHandler<Queries.GetPaymentBy, PaymentByVM>
    {
        public GetPaymentByQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<PaymentByVM> Handle(Queries.GetPaymentBy request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetPaymentByById({request.PaymentById})";
            var query = $"SELECT * from PaymentBy where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<PaymentByVM>(query);
            return data;
        }
    }
}
