using Dapper;
using ISPCore.Application.ClientCableAssign.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ClientCableAssign.Queries
{
    public class GetClientCableAssignQueryHandler : IRequestHandler<Queries.GetClientCableAssign, ClientCableAssignVM>
    {
        public GetClientCableAssignQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<ClientCableAssignVM> Handle(Queries.GetClientCableAssign request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetClientCableAssignById({request.ClientCableAssignId})";
            var query = $"SELECT * from ClientCableAssign where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<ClientCableAssignVM>(query);
            return data;
        }
    }
}
