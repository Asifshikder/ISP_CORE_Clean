using Dapper;
using ISPCore.Application.EmployeeTransactionLockUnlock.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.EmployeeTransactionLockUnlock.Queries
{
    public class GetEmployeeTransactionLockUnlockListQueryHandler : IRequestHandler<Queries.GetEmployeeTransactionLockUnlockList, List<EmployeeTransactionLockUnlockVM>>
    {
        public GetEmployeeTransactionLockUnlockListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<EmployeeTransactionLockUnlockVM>> Handle(Queries.GetEmployeeTransactionLockUnlockList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, ,TransactionID,PackageID,Amount,AmountForReseller,FromDate,ToDate,LockOrUnlockDate,EmployeeID,ResellerID" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<EmployeeTransactionLockUnlockVM>(query);
            return data.ToList();
        }
    }
}
