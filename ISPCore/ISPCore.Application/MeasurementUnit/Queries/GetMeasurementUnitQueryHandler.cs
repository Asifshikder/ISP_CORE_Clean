using Dapper;
using ISPCore.Application.MeasurementUnit.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.MeasurementUnit.Queries
{
    public class GetMeasurementUnitQueryHandler : IRequestHandler<Queries.GetMeasurementUnit, MeasurementUnitVM>
    {
        public GetMeasurementUnitQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<MeasurementUnitVM> Handle(Queries.GetMeasurementUnit request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetMeasurementUnitById({request.MeasurementUnitId})";
            var query = $"SELECT * from MeasurementUnit where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<MeasurementUnitVM>(query);
            return data;
        }
    }
}
