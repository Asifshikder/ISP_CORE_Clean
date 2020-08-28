using Dapper;
using ISPCore.Application.Role.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Role.Queries
{
    public class GetRoleListQueryHandler : IRequestHandler<Queries.GetRoleList, List<RoleVM>>
    {
        public GetRoleListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<RoleVM>> Handle(Queries.GetRoleList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, RoleName"+"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<RoleVM>(query);
            return data.ToList();
        }
    }
}
