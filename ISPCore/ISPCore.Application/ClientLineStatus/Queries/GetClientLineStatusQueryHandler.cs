using Dapper;
using ISPCore.Application.ClientLineStatus.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ClientLineStatus.Queries
{
    public class GetClientLineStatusQueryHandler : IRequestHandler<Queries.GetClientLineStatus, ClientLineStatusVM>
    {
        public GetClientLineStatusQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<ClientLineStatusVM> Handle(Queries.GetClientLineStatus request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetClientLineStatusById({request.ClientLineStatusId})";
            var query = $"SELECT * from ClientLineStatus where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<ClientLineStatusVM>(query);
            return data;
        }
    }
}
