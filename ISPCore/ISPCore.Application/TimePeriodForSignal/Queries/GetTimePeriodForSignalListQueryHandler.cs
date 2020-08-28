using Dapper;
using ISPCore.Application.TimePeriodForSignal.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.TimePeriodForSignal.Queries
{
    public class GetTimePeriodForSignalListQueryHandler : IRequestHandler<Queries.GetTimePeriodForSignalList, List<TimePeriodForSignalVM>>
    {
        public GetTimePeriodForSignalListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<TimePeriodForSignalVM>> Handle(Queries.GetTimePeriodForSignalList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, UpToHours,SignalSign" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<TimePeriodForSignalVM>(query);
            return data.ToList();
        }
    }
}
