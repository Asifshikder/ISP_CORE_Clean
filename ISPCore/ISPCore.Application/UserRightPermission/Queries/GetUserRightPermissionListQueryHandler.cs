using Dapper;
using ISPCore.Application.UserRightPermission.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.UserRightPermission.Queries
{
    public class GetUserRightPermissionListQueryHandler : IRequestHandler<Queries.GetUserRightPermissionList, List<UserRightPermissionVM>>
    {
        public GetUserRightPermissionListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<UserRightPermissionVM>> Handle(Queries.GetUserRightPermissionList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, UserRightPermissionName,UserRightPermissionDescription,UserRightPermissionDetails" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<UserRightPermissionVM>(query);
            return data.ToList();
        }
    }
}
