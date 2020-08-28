using Dapper;
using ISPCore.Application.Box.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Box.Queries
{
    public class GetBoxListQueryHandler : IRequestHandler<Queries.GetBoxList, List<BoxVM>>
    {
        public GetBoxListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<BoxVM>> Handle(Queries.GetBoxList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, BoxName,ResellerID,BoxLocation"+"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<BoxVM>(query);
            return data.ToList();
        }
    }
}
