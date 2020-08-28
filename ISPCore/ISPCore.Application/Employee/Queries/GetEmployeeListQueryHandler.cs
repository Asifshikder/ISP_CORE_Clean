using Dapper;
using ISPCore.Application.Employee.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Employee.Queries
{
    public class GetEmployeeListQueryHandler : IRequestHandler<Queries.GetEmployeeList, List<EmployeeVM>>
    {
        public GetEmployeeListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<EmployeeVM>> Handle(Queries.GetEmployeeList request, CancellationToken cancellationToken)
        {
            var query = $"select Id,Name,LoginName,Password,Phone,Address,Email,DepartmentID,RoleID,UserRightPermissionID,DOB,DeviceID,DutyShiftID,Salary,EmployeeID,BreakHour,BreakMinute,DutyShiftCombined,EmployeeOwnImageBytes,EmployeeOwnImageBytesPaths,EmployeeNIDImageBytes,EmployeeNIDImageBytesPaths,ResellerID"+"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<EmployeeVM>(query);
            return data.ToList();
        }
    }
}
