using Dapper;
using ISPCore.Application.PaymentBy.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.PaymentBy.Queries
{
    public class GetPaymentByListQueryHandler : IRequestHandler<Queries.GetPaymentByList, List<PaymentByVM>>
    {
        public GetPaymentByListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<PaymentByVM>> Handle(Queries.GetPaymentByList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, PaymentByName"+"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<PaymentByVM>(query);
            return data.ToList();
        }
    }
}
