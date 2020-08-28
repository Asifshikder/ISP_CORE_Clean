using Dapper;
using ISPCore.Application.Role.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Role.Queries
{
    public class GetRoleQueryHandler : IRequestHandler<Queries.GetRole, RoleVM>
    {
        public GetRoleQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<RoleVM> Handle(Queries.GetRole request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetRoleById({request.RoleId})";
            var query = $"SELECT * from Role where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<RoleVM>(query);
            return data;
        }
    }
}
