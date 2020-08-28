using Dapper;
using ISPCore.Application.DistributionReason.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.DistributionReason.Queries
{
    public class GetDistributionReasonListQueryHandler : IRequestHandler<Queries.GetDistributionReasonList, List<DistributionReasonVM>>
    {
        public GetDistributionReasonListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<DistributionReasonVM>> Handle(Queries.GetDistributionReasonList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, DistributionReasonName"+"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<DistributionReasonVM>(query);
            return data.ToList();
        }
    }
}
