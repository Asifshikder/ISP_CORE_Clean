using Dapper;
using ISPCore.Application.ResellerBillingCycle.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ResellerBillingCycle.Queries
{
    public class GetResellerBillingCycleListQueryHandler : IRequestHandler<Queries.GetResellerBillingCycleList, List<ResellerBillingCycleVM>>
    {
        public GetResellerBillingCycleListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<ResellerBillingCycleVM>> Handle(Queries.GetResellerBillingCycleList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, Day"+"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<ResellerBillingCycleVM>(query);
            return data.ToList();
        }
    }
}
