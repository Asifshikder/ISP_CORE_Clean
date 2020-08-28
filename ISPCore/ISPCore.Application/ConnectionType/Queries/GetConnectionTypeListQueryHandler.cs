using Dapper;
using ISPCore.Application.ConnectionType.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ConnectionType.Queries
{
    public class GetConnectionTypeListQueryHandler : IRequestHandler<Queries.GetConnectionTypeList, List<ConnectionTypeVM>>
    {
        public GetConnectionTypeListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<ConnectionTypeVM>> Handle(Queries.GetConnectionTypeList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, ConnectionTypeName"+"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<ConnectionTypeVM>(query);
            return data.ToList();
        }
    }
}
