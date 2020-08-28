using Dapper;
using ISPCore.Application.CableDistribution.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.CableDistribution.Queries
{
    public class GetCableDistributionQueryHandler : IRequestHandler<Queries.GetCableDistribution, CableDistributionVM>
    {
        public GetCableDistributionQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<CableDistributionVM> Handle(Queries.GetCableDistribution request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetCableDistributionById({request.CableDistributionId})";
            var query = $"SELECT * from CableDistribution where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<CableDistributionVM>(query);
            return data;
        }
    }
}
