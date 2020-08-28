using Dapper;
using ISPCore.Application.LineStatus.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.LineStatus.Queries
{
    public class GetLineStatusListQueryHandler : IRequestHandler<Queries.GetLineStatusList, List<LineStatusVM>>
    {
        public GetLineStatusListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<LineStatusVM>> Handle(Queries.GetLineStatusList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, LineStatusName"+"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<LineStatusVM>(query);
            return data.ToList();
        }
    }
}
