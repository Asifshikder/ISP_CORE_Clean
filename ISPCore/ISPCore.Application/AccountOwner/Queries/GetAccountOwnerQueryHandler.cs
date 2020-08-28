using Dapper;
using ISPCore.Application.AccountOwner.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.AccountOwner.Queries
{
    public class GetAccountOwnerQueryHandler : IRequestHandler<Queries.GetAccountOwner, AccountOwnerVM>
    {
        public GetAccountOwnerQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<AccountOwnerVM> Handle(Queries.GetAccountOwner request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetAccountOwnerById({request.AccountOwnerId})";
            var query = $"SELECT * from AccountOwner where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<AccountOwnerVM>(query);
            return data;
        }
    }
}
