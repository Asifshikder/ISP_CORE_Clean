using Dapper;
using ISPCore.Application.ConnectionType.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ConnectionType.Queries
{
    public class GetConnectionTypeQueryHandler : IRequestHandler<Queries.GetConnectionType, ConnectionTypeVM>
    {
        public GetConnectionTypeQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<ConnectionTypeVM> Handle(Queries.GetConnectionType request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetConnectionTypeById({request.ConnectionTypeId})";
            var query = $"SELECT * from ConnectionType where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<ConnectionTypeVM>(query);
            return data;
        }
    }
}
