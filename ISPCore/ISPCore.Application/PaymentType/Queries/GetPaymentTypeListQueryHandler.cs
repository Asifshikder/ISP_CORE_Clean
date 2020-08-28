using Dapper;
using ISPCore.Application.PaymentType.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.PaymentType.Queries
{
    public class GetPaymentTypeListQueryHandler : IRequestHandler<Queries.GetPaymentTypeList, List<PaymentTypeVM>>
    {
        public GetPaymentTypeListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<PaymentTypeVM>> Handle(Queries.GetPaymentTypeList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, PaymentTypeName"+"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<PaymentTypeVM>(query);
            return data.ToList();
        }
    }
}
