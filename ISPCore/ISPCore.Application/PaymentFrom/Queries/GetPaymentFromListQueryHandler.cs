using Dapper;
using ISPCore.Application.PaymentFrom.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.PaymentFrom.Queries
{
    public class GetPaymentFromListQueryHandler : IRequestHandler<Queries.GetPaymentFromList, List<PaymentFromVM>>
    {
        public GetPaymentFromListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<PaymentFromVM>> Handle(Queries.GetPaymentFromList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, PaymentFromName"+"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<PaymentFromVM>(query);
            return data.ToList();
        }
    }
}
