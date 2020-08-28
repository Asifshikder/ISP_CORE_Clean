using Dapper;
using ISPCore.Application.AccountListVsAmmountTransfer.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.AccountListVsAmmountTransfer.Queries
{
    public class GetAccountListVsAmmountTransferListQueryHandler : IRequestHandler<Queries.GetAccountListVsAmmountTransferList, List<AccountListVsAmmountTransferVM>>
    {
        public GetAccountListVsAmmountTransferListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<AccountListVsAmmountTransferVM>> Handle(Queries.GetAccountListVsAmmountTransferList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, FromAccountID,ToAccountID,TransferDate,CurrencyID,Amount,Description,Tags,PaymentByID,References,BreakDownAccountListID,TransferType" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<AccountListVsAmmountTransferVM>(query);
            return data.ToList();
        }
    }
}
