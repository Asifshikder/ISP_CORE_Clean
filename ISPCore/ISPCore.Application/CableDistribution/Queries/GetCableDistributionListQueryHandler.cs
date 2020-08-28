using Dapper;
using ISPCore.Application.CableDistribution.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.CableDistribution.Queries
{
    public class GetCableDistributionListQueryHandler : IRequestHandler<Queries.GetCableDistributionList, List<CableDistributionVM>>
    {
        public GetCableDistributionListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<CableDistributionVM>> Handle(Queries.GetCableDistributionList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, ClientDetailsID,EmployeeID,CableForEmployeeID,CableStockID,AmountOfCableUsed,Purpose,CableAssignFromWhere,CableIndicatorStatus,Remarks" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<CableDistributionVM>(query);
            return data.ToList();
        }
    }
}
