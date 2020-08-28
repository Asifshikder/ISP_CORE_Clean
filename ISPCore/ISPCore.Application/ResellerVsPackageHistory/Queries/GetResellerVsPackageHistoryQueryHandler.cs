using Dapper;
using ISPCore.Application.ResellerVsPackageHistory.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ResellerVsPackageHistory.Queries
{
    public class GetResellerVsPackageHistoryQueryHandler : IRequestHandler<Queries.GetResellerVsPackageHistory, ResellerVsPackageHistoryVM>
    {
        public GetResellerVsPackageHistoryQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<ResellerVsPackageHistoryVM> Handle(Queries.GetResellerVsPackageHistory request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetResellerVsPackageHistoryById({request.ResellerVsPackageHistoryId})";
            var query = $"SELECT * from ResellerVsPackageHistory where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<ResellerVsPackageHistoryVM>(query);
            return data;
        }
    }
}
