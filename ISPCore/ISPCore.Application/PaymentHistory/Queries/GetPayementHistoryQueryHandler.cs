using Dapper;
using ISPCore.Application.PayementHistory.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.PayementHistory.Queries
{
    public class GetPayementHistoryQueryHandler : IRequestHandler<Queries.GetPayementHistory, PayementHistoryVM>
    {
        public GetPayementHistoryQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<PayementHistoryVM> Handle(Queries.GetPayementHistory request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetPayementHistoryById({request.PayementHistoryId})";
            var query = $"SELECT * from PayementHistory where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<PayementHistoryVM>(query);
            return data;
        }
    }
}
