using Dapper;
using ISPCore.Application.EmployeeVsWorkSchedule.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.EmployeeVsWorkSchedule.Queries
{
    public class GetEmployeeVsWorkScheduleQueryHandler : IRequestHandler<Queries.GetEmployeeVsWorkSchedule, EmployeeVsWorkScheduleVM>
    {
        public GetEmployeeVsWorkScheduleQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<EmployeeVsWorkScheduleVM> Handle(Queries.GetEmployeeVsWorkSchedule request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetEmployeeVsWorkScheduleById({request.EmployeeVsWorkScheduleId})";
            var query = $"SELECT * from EmployeeVsWorkSchedule where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<EmployeeVsWorkScheduleVM>(query);
            return data;
        }
    }
}
