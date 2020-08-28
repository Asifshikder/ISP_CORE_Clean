using Dapper;
using ISPCore.Application.Deposit.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Deposit.Queries
{
    public class GetDepositQueryHandler : IRequestHandler<Queries.GetDeposit, DepositVM>
    {
        public GetDepositQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<DepositVM> Handle(Queries.GetDeposit request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetDepositById({request.DepositId})";
            var query = $"SELECT * from Deposit where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<DepositVM>(query);
            return data;
        }
    }
}
