using Dapper;
using ISPCore.Application.AdvancePayment.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.AdvancePayment.Queries
{
    public class GetAdvancePaymentListQueryHandler : IRequestHandler<Queries.GetAdvancePaymentList, List<AdvancePaymentVM>>
    {
        public GetAdvancePaymentListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<AdvancePaymentVM>> Handle(Queries.GetAdvancePaymentList request, CancellationToken cancellationToken)
        {
            var query = $"select Id,ClientDetailsID,AdvanceAmount,Remarks,CollectBy" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<AdvancePaymentVM>(query);
            return data.ToList();
        }
    }
}
