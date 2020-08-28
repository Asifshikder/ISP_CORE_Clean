using Dapper;
using ISPCore.Application.Complain.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Complain.Queries
{
    public class GetComplainQueryHandler : IRequestHandler<Queries.GetComplain, ComplainVM>
    {
        public GetComplainQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<ComplainVM> Handle(Queries.GetComplain request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetComplainById({request.ComplainId})";
            var query = $"SELECT * from Complain where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<ComplainVM>(query);
            return data;
        }
    }
}
