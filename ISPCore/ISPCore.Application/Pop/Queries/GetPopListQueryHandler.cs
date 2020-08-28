using Dapper;
using ISPCore.Application.Pop.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Pop.Queries
{
    public class GetPopListQueryHandler : IRequestHandler<Queries.GetPopList, List<PopVM>>
    {
        public GetPopListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<PopVM>> Handle(Queries.GetPopList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, PopName,PopLocation" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<PopVM>(query);
            return data.ToList();
        }
    }
}
