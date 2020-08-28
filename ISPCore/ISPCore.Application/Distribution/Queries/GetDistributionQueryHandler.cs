using Dapper;
using ISPCore.Application.Distribution.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Distribution.Queries
{
    public class GetDistributionQueryHandler : IRequestHandler<Queries.GetDistribution, DistributionVM>
    {
        public GetDistributionQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<DistributionVM> Handle(Queries.GetDistribution request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetDistributionById({request.DistributionId})";
            var query = $"SELECT * from Distribution where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<DistributionVM>(query);
            return data;
        }
    }
}
