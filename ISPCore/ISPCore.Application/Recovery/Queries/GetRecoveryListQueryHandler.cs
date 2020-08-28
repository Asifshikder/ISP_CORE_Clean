using Dapper;
using ISPCore.Application.Recovery.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Recovery.Queries
{
    public class GetRecoveryListQueryHandler : IRequestHandler<Queries.GetRecoveryList, List<RecoveryVM>>
    {
        public GetRecoveryListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<RecoveryVM>> Handle(Queries.GetRecoveryList request, CancellationToken cancellationToken)
        {
            var query = $"select Id,EmployeeID,DistributionReasonID,DistributionID,StockDetailsID,PopID,BoxID,ClientDetailsID,RecoveryDate,IndicatorStatus" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<RecoveryVM>(query);
            return data.ToList();
        }
    }
}
