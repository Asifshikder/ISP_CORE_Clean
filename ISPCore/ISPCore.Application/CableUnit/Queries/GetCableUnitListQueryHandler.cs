using Dapper;
using ISPCore.Application.CableUnit.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.CableUnit.Queries
{
    public class GetCableUnitListQueryHandler : IRequestHandler<Queries.GetCableUnitList, List<CableUnitVM>>
    {
        public GetCableUnitListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<CableUnitVM>> Handle(Queries.GetCableUnitList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, CableUnitName"+"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<CableUnitVM>(query);
            return data.ToList();
        }
    }
}
