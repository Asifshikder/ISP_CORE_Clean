using Dapper;
using ISPCore.Application.Mikrotik.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Mikrotik.Queries
{
    public class GetMikrotikQueryHandler : IRequestHandler<Queries.GetMikrotik, MikrotikVM>
    {
        public GetMikrotikQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<MikrotikVM> Handle(Queries.GetMikrotik request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetMikrotikById({request.MikrotikId})";
            var query = $"SELECT * from Mikrotik where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<MikrotikVM>(query);
            return data;
        }
    }
}
