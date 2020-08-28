using Dapper;
using ISPCore.Application.AccountList.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.AccountList.Queries
{
    public class GetAccountListListQueryHandler : IRequestHandler<Queries.GetAccountListList, List<AccountListVM>>
    {
        public GetAccountListListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<AccountListVM>> Handle(Queries.GetAccountListList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, AccountTitle,Description,InitialBalance,AccountNumber,ContactPerson,Phone,BankURL,OwnerID" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<AccountListVM>(query);
            return data.ToList();
        }
    }
}
