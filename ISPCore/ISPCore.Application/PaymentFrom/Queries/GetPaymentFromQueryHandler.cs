using Dapper;
using ISPCore.Application.PaymentFrom.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.PaymentFrom.Queries
{
    public class GetPaymentFromQueryHandler : IRequestHandler<Queries.GetPaymentFrom, PaymentFromVM>
    {
        public GetPaymentFromQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<PaymentFromVM> Handle(Queries.GetPaymentFrom request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetPaymentFromById({request.PaymentFromId})";
            var query = $"SELECT * from PaymentFrom where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<PaymentFromVM>(query);
            return data;
        }
    }
}
