using Dapper;
using ISPCore.Application.ClientCableDistribution.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ClientCableDistribution.Queries
{
    public class GetClientCableDistributionQueryHandler : IRequestHandler<Queries.GetClientCableDistribution, ClientCableDistributionVM>
    {
        public GetClientCableDistributionQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<ClientCableDistributionVM> Handle(Queries.GetClientCableDistribution request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetClientCableDistributionById({request.ClientCableDistributionId})";
            var query = $"SELECT * from ClientCableDistribution where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<ClientCableDistributionVM>(query);
            return data;
        }
    }
}
