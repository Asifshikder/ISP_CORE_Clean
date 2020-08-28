using Dapper;
using ISPCore.Application.ResellerVsPackageHistory.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ResellerVsPackageHistory.Queries
{
    public class GetResellerVsPackageHistoryListQueryHandler : IRequestHandler<Queries.GetResellerVsPackageHistoryList, List<ResellerVsPackageHistoryVM>>
    {
        public GetResellerVsPackageHistoryListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<ResellerVsPackageHistoryVM>> Handle(Queries.GetResellerVsPackageHistoryList request, CancellationToken cancellationToken)
        {
            var query = $"select Id,  ResellerID, ResellerName, ResellerPackageID, PackageName, PackagePrice" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<ResellerVsPackageHistoryVM>(query);
            return data.ToList();
        }
    }
}
