using Dapper;
using ISPCore.Application.Transaction.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Transaction.Queries
{
    public class GetTransactionQueryHandler : IRequestHandler<Queries.GetTransaction, TransactionVM>
    {
        public GetTransactionQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<TransactionVM> Handle(Queries.GetTransaction request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetTransactionById({request.TransactionId})";
            var query = $"SELECT * from Transaction where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<TransactionVM>(query);
            return data;
        }
    }
}
