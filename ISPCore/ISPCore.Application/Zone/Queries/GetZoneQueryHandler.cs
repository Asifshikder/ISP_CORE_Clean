using Dapper;
using ISPCore.Application.Zone.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Zone.Queries
{
    public class GetZoneQueryHandler : IRequestHandler<Queries.GetZone, ZoneVM>
    {
        public GetZoneQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<ZoneVM> Handle(Queries.GetZone request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetZoneById({request.ZoneId})";
            var query = $"SELECT * from Zone where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<ZoneVM>(query);
            return data;
        }
    }
}
