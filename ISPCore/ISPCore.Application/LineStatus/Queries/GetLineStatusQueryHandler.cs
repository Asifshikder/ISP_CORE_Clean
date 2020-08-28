using Dapper;
using ISPCore.Application.LineStatus.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.LineStatus.Queries
{
    public class GetLineStatusQueryHandler : IRequestHandler<Queries.GetLineStatus, LineStatusVM>
    {
        public GetLineStatusQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<LineStatusVM> Handle(Queries.GetLineStatus request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetLineStatusById({request.LineStatusId})";
            var query = $"SELECT * from LineStatus where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<LineStatusVM>(query);
            return data;
        }
    }
}
