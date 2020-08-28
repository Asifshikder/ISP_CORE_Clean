using Dapper;
using ISPCore.Application.AccountList.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.AccountList.Queries
{
    public class GetAccountListQueryHandler : IRequestHandler<Queries.GetAccountList, AccountListVM>
    {
        public GetAccountListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<AccountListVM> Handle(Queries.GetAccountList request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetAccountListById({request.AccountListId})";
            var query = $"SELECT * from AccountList where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<AccountListVM>(query);
            return data;
        }
    }
}
