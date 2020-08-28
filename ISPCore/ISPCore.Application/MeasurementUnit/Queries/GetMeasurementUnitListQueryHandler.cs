using Dapper;
using ISPCore.Application.MeasurementUnit.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.MeasurementUnit.Queries
{
    public class GetMeasurementUnitListQueryHandler : IRequestHandler<Queries.GetMeasurementUnitList, List<MeasurementUnitVM>>
    {
        public GetMeasurementUnitListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<MeasurementUnitVM>> Handle(Queries.GetMeasurementUnitList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, MeasurementUnitName"+"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<MeasurementUnitVM>(query);
            return data.ToList();
        }
    }
}
