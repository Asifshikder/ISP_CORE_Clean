using Dapper;
using ISPCore.Application.CableUnit.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.CableUnit.Queries
{
    public class GetCableUnitQueryHandler : IRequestHandler<Queries.GetCableUnit, CableUnitVM>
    {
        public GetCableUnitQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<CableUnitVM> Handle(Queries.GetCableUnit request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetCableUnitById({request.CableUnitId})";
            var query = $"SELECT * from CableUnit where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<CableUnitVM>(query);
            return data;
        }
    }
}
