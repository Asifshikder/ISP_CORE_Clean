using Dapper;
using ISPCore.Application.UserRightPermission.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.UserRightPermission.Queries
{
    public class GetUserRightPermissionQueryHandler : IRequestHandler<Queries.GetUserRightPermission, UserRightPermissionVM>
    {
        public GetUserRightPermissionQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<UserRightPermissionVM> Handle(Queries.GetUserRightPermission request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetUserRightPermissionById({request.UserRightPermissionId})";
            var query = $"SELECT * from UserRightPermission where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<UserRightPermissionVM>(query);
            return data;
        }
    }
}
