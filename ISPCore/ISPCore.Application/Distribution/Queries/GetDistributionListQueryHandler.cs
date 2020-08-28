using Dapper;
using ISPCore.Application.Distribution.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Distribution.Queries
{
    public class GetDistributionListQueryHandler : IRequestHandler<Queries.GetDistributionList, List<DistributionVM>>
    {
        public GetDistributionListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<DistributionVM>> Handle(Queries.GetDistributionList request, CancellationToken cancellationToken)
        {
            var query = $"select Id,EmployeeID,StockDetailsID,PopID,BoxID,ClientDetailsID,DistributionReasonID, IndicatorStatus, Remarks" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<DistributionVM>(query);
            return data.ToList();
        }
    }
}
