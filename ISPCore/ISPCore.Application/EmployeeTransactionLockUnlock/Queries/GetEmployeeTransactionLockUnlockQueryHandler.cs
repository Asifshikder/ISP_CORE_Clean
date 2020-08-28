using Dapper;
using ISPCore.Application.EmployeeTransactionLockUnlock.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.EmployeeTransactionLockUnlock.Queries
{
    public class GetEmployeeTransactionLockUnlockQueryHandler : IRequestHandler<Queries.GetEmployeeTransactionLockUnlock, EmployeeTransactionLockUnlockVM>
    {
        public GetEmployeeTransactionLockUnlockQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<EmployeeTransactionLockUnlockVM> Handle(Queries.GetEmployeeTransactionLockUnlock request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetEmployeeTransactionLockUnlockById({request.EmployeeTransactionLockUnlockId})";
            var query = $"SELECT * from EmployeeTransactionLockUnlock where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<EmployeeTransactionLockUnlockVM>(query);
            return data;
        }
    }
}
