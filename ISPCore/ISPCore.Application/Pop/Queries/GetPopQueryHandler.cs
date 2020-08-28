using Dapper;
using ISPCore.Application.Pop.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Pop.Queries
{
    public class GetPopQueryHandler : IRequestHandler<Queries.GetPop, PopVM>
    {
        public GetPopQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<PopVM> Handle(Queries.GetPop request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetPopById({request.PopId})";
            var query = $"SELECT * from Pop where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<PopVM>(query);
            return data;
        }
    }
}
