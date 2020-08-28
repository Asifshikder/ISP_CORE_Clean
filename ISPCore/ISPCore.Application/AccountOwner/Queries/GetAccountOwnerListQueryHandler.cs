using Dapper;
using ISPCore.Application.AccountOwner.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.AccountOwner.Queries
{
    public class GetAccountOwnerListQueryHandler : IRequestHandler<Queries.GetAccountOwnerList, List<AccountOwnerVM>>
    {
        public GetAccountOwnerListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<AccountOwnerVM>> Handle(Queries.GetAccountOwnerList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, AccountOwnerName"+"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<AccountOwnerVM>(query);
            return data.ToList();
        }
    }
}
