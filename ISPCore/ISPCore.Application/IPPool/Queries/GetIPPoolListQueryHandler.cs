using Dapper;
using ISPCore.Application.IPPool.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.IPPool.Queries
{
    public class GetIPPoolListQueryHandler : IRequestHandler<Queries.GetIPPoolList, List<IPPoolVM>>
    {
        public GetIPPoolListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<IPPoolVM>> Handle(Queries.GetIPPoolList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, IPPoolName,StartRange,EndRange" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<IPPoolVM>(query);
            return data.ToList();
        }
    }
}
