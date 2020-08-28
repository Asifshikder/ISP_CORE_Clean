using Dapper;
using ISPCore.Application.AttendanceType.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.AttendanceType.Queries
{
    public class GetAttendanceTypeQueryHandler : IRequestHandler<Queries.GetAttendanceType, AttendanceTypeVM>
    {
        public GetAttendanceTypeQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<AttendanceTypeVM> Handle(Queries.GetAttendanceType request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetAttendanceTypeById({request.AttendanceTypeId})";
            var query = $"SELECT * from AttendanceType where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<AttendanceTypeVM>(query);
            return data;
        }
    }
}
