using Dapper;
using ISPCore.Application.EmployeeLeaveHistory.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.EmployeeLeaveHistory.Queries
{
    public class GetEmployeeLeaveHistoryQueryHandler : IRequestHandler<Queries.GetEmployeeLeaveHistory, EmployeeLeaveHistoryVM>
    {
        public GetEmployeeLeaveHistoryQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<EmployeeLeaveHistoryVM> Handle(Queries.GetEmployeeLeaveHistory request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetEmployeeLeaveHistoryById({request.EmployeeLeaveHistoryId})";
            var query = $"SELECT * from EmployeeLeaveHistory where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<EmployeeLeaveHistoryVM>(query);
            return data;
        }
    }
}
