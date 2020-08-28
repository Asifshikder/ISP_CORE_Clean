using Dapper;
using ISPCore.Application.EmployeeLeaveHistory.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.EmployeeLeaveHistory.Queries
{
    public class GetEmployeeLeaveHistoryListQueryHandler : IRequestHandler<Queries.GetEmployeeLeaveHistoryList, List<EmployeeLeaveHistoryVM>>
    {
        public GetEmployeeLeaveHistoryListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<EmployeeLeaveHistoryVM>> Handle(Queries.GetEmployeeLeaveHistoryList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, EmployeeID,Reason,LeaveSalaryTypeID,StartDate,EndDate" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<EmployeeLeaveHistoryVM>(query);
            return data.ToList();
        }
    }
}
