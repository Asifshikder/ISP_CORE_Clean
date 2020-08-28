using Dapper;
using ISPCore.Application.PaymentType.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.PaymentType.Queries
{
    public class GetPaymentTypeQueryHandler : IRequestHandler<Queries.GetPaymentType, PaymentTypeVM>
    {
        public GetPaymentTypeQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<PaymentTypeVM> Handle(Queries.GetPaymentType request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetPaymentTypeById({request.PaymentTypeId})";
            var query = $"SELECT * from PaymentType where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<PaymentTypeVM>(query);
            return data;
        }
    }
}
