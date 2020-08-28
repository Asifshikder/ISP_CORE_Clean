using Dapper;
using ISPCore.Application.Head.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Head.Queries
{
    public class GetHeadQueryHandler : IRequestHandler<Queries.GetHead, HeadVM>
    {
        public GetHeadQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<HeadVM> Handle(Queries.GetHead request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetHeadById({request.HeadId})";
            var query = $"SELECT * from Head where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<HeadVM>(query);
            return data;
        }
    }
}
