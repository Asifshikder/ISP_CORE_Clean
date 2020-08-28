using Dapper;
using ISPCore.Application.Distribution_Transaction.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Distribution_Transaction.Queries
{
    public class GetDistribution_TransactionQueryHandler : IRequestHandler<Queries.GetDistribution_Transaction, Distribution_TransactionVM>
    {
        public GetDistribution_TransactionQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<Distribution_TransactionVM> Handle(Queries.GetDistribution_Transaction request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetDistribution_TransactionById({request.Distribution_TransactionId})";
            var query = $"SELECT * from Distribution_Transaction where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<Distribution_TransactionVM>(query);
            return data;
        }
    }
}
