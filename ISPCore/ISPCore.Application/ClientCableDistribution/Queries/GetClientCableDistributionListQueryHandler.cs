using Dapper;
using ISPCore.Application.ClientCableDistribution.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ClientCableDistribution.Queries
{
    public class GetClientCableDistributionListQueryHandler : IRequestHandler<Queries.GetClientCableDistributionList, List<ClientCableDistributionVM>>
    {
        public GetClientCableDistributionListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<ClientCableDistributionVM>> Handle(Queries.GetClientCableDistributionList request, CancellationToken cancellationToken)
        {
            var query = $"select Id,CableQuantity,EmployeeID,ClientID,AssignEmployee" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<ClientCableDistributionVM>(query);
            return data.ToList();
        }
    }
}
