using Dapper;
using ISPCore.Application.Zone.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Zone.Queries
{
    public class GetZoneListQueryHandler : IRequestHandler<Queries.GetZoneList, List<ZoneVM>>
    {
        public GetZoneListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<ZoneVM>> Handle(Queries.GetZoneList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, ZoneName,ResellerID" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<ZoneVM>(query);
            return data.ToList();
        }
    }
}
