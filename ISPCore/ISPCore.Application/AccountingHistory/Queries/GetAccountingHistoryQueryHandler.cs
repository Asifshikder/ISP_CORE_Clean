using Dapper;
using ISPCore.Application.AccountingHistory.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.AccountingHistory.Queries
{
    public class GetAccountingHistoryQueryHandler : IRequestHandler<Queries.GetAccountingHistory, AccountingHistoryVM>
    {
        public GetAccountingHistoryQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<AccountingHistoryVM> Handle(Queries.GetAccountingHistory request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetAccountingHistoryById({request.AccountingHistoryId})";
            var query = $"SELECT * from AccountingHistory where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<AccountingHistoryVM>(query);
            return data;
        }
    }
}
