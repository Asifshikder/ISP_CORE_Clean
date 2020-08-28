using Dapper;
using ISPCore.Application.Day.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Day.Queries
{
    public class GetDayListQueryHandler : IRequestHandler<Queries.GetDayList, List<DayVM>>
    {
        public GetDayListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<DayVM>> Handle(Queries.GetDayList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, DayName"+"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<DayVM>(query);
            return data.ToList();
        }
    }
}
