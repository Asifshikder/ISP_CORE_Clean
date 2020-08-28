using Dapper;
using ISPCore.Application.EmployeeVsWorkSchedule.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.EmployeeVsWorkSchedule.Queries
{
    public class GetEmployeeVsWorkScheduleListQueryHandler : IRequestHandler<Queries.GetEmployeeVsWorkScheduleList, List<EmployeeVsWorkScheduleVM>>
    {
        public GetEmployeeVsWorkScheduleListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<EmployeeVsWorkScheduleVM>> Handle(Queries.GetEmployeeVsWorkScheduleList request, CancellationToken cancellationToken)
        {
            var query = $"select Id,DayID,StartHour,StartMinute,RunHour,RunMinute,BreakStartHour,BreakStartMinute,BreakEndHour,BreakEndMinute,EmployeeID" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<EmployeeVsWorkScheduleVM>(query);
            return data.ToList();
        }
    }
}
