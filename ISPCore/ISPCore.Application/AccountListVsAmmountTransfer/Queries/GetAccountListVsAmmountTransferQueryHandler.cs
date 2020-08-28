using Dapper;
using ISPCore.Application.AccountListVsAmmountTransfer.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.AccountListVsAmmountTransfer.Queries
{
    public class GetAccountListVsAmmountTransferQueryHandler : IRequestHandler<Queries.GetAccountListVsAmmountTransfer, AccountListVsAmmountTransferVM>
    {
        public GetAccountListVsAmmountTransferQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<AccountListVsAmmountTransferVM> Handle(Queries.GetAccountListVsAmmountTransfer request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetAccountListVsAmmountTransferById({request.AccountListVsAmmountTransferId})";
            var query = $"SELECT * from AccountListVsAmmountTransfer where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<AccountListVsAmmountTransferVM>(query);
            return data;
        }
    }
}
