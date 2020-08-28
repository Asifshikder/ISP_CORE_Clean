using Dapper;
using ISPCore.Application.ControllerName.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ControllerName.Queries
{
    public class GetControllerNameQueryHandler : IRequestHandler<Queries.GetControllerName, ControllerNameVM>
    {
        public GetControllerNameQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<ControllerNameVM> Handle(Queries.GetControllerName request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetControllerNameById({request.ControllerNameId})";
            var query = $"SELECT * from ControllerName where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<ControllerNameVM>(query);
            return data;
        }
    }
}
