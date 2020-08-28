using Dapper;
using ISPCore.Application.BillGenerateHistory.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.BillGenerateHistory.Queries
{
    public class GetBillGenerateHistoryQueryHandler : IRequestHandler<Queries.GetBillGenerateHistory, BillGenerateHistoryVM>
    {
        public GetBillGenerateHistoryQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<BillGenerateHistoryVM> Handle(Queries.GetBillGenerateHistory request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetBillGenerateHistoryById({request.BillGenerateHistoryId})";
            var query = $"SELECT * from BillGenerateHistory where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<BillGenerateHistoryVM>(query);
            return data;
        }
    }
}
