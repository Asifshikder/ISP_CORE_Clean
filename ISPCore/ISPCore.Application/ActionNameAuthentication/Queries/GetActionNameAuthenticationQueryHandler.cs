using Dapper;
using ISPCore.Application.ActionNameAuthentication.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ActionNameAuthentication.Queries
{
    public class GetActionNameAuthenticationQueryHandler : IRequestHandler<Queries.GetActionNameAuthentication, ActionNameAuthenticationVM>
    {
        public GetActionNameAuthenticationQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<ActionNameAuthenticationVM> Handle(Queries.GetActionNameAuthentication request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetActionNameAuthenticationById({request.ActionNameAuthenticationId})";
            var query = $"SELECT * from ActionNameAuthentication where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<ActionNameAuthenticationVM>(query);
            return data;
        }
    }
}
