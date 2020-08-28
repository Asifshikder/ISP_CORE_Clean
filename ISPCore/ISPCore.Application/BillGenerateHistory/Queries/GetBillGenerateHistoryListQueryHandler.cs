using Dapper;
using ISPCore.Application.BillGenerateHistory.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.BillGenerateHistory.Queries
{
    public class GetBillGenerateHistoryListQueryHandler : IRequestHandler<Queries.GetBillGenerateHistoryList, List<BillGenerateHistoryVM>>
    {
        public GetBillGenerateHistoryListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<BillGenerateHistoryVM>> Handle(Queries.GetBillGenerateHistoryList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, Year,Month"+"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<BillGenerateHistoryVM>(query);
            return data.ToList();
        }
    }
}
