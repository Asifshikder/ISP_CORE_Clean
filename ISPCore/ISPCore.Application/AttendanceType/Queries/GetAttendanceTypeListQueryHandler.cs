using Dapper;
using ISPCore.Application.AttendanceType.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.AttendanceType.Queries
{
    public class GetAttendanceTypeListQueryHandler : IRequestHandler<Queries.GetAttendanceTypeList, List<AttendanceTypeVM>>
    {
        public GetAttendanceTypeListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<AttendanceTypeVM>> Handle(Queries.GetAttendanceTypeList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, AttendanceTypeName"+"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<AttendanceTypeVM>(query);
            return data.ToList();
        }
    }
}
