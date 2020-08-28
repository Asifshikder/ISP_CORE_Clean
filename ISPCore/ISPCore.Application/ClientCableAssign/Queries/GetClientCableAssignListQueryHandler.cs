using Dapper;
using ISPCore.Application.ClientCableAssign.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ClientCableAssign.Queries
{
    public class GetClientCableAssignListQueryHandler : IRequestHandler<Queries.GetClientCableAssignList, List<ClientCableAssignVM>>
    {
        public GetClientCableAssignListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<ClientCableAssignVM>> Handle(Queries.GetClientCableAssignList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, CableQuantity,EmployeeID" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<ClientCableAssignVM>(query);
            return data.ToList();
        }
    }
}
