using Dapper;
using ISPCore.Application.Employee.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Employee.Queries
{
    public class GetEmployeeQueryHandler : IRequestHandler<Queries.GetEmployee, EmployeeVM>
    {
        public GetEmployeeQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<EmployeeVM> Handle(Queries.GetEmployee request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetEmployeeById({request.EmployeeId})";
            var query = $"SELECT * from Employee where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<EmployeeVM>(query);
            return data;
        }
    }
}
