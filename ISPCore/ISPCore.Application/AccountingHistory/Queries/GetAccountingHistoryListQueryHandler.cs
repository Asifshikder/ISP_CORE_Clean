using Dapper;
using ISPCore.Application.AccountingHistory.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.AccountingHistory.Queries
{
    public class GetAccountingHistoryListQueryHandler : IRequestHandler<Queries.GetAccountingHistoryList, List<AccountingHistoryVM>>
    {
        public GetAccountingHistoryListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<AccountingHistoryVM>> Handle(Queries.GetAccountingHistoryList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, AccountListID,PurchaseID,SalesID,DepositID,ExpenseID,ActionTypeID,DRCRTypeID,Amount,Year,Month,Day,Date,Description" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<AccountingHistoryVM>(query);
            return data.ToList();
        }
    }
}
