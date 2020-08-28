using Dapper;
using ISPCore.Application.Box.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Box.Queries
{
    public class GetBoxQueryHandler : IRequestHandler<Queries.GetBox, BoxVM>
    {
        public GetBoxQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<BoxVM> Handle(Queries.GetBox request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetBoxById({request.BoxId})";
            var query = $"SELECT * from Box where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<BoxVM>(query);
            return data;
        }
    }
}
