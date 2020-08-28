using Dapper;
using ISPCore.Application.Month.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Month.Queries
{
    public class GetMonthListQueryHandler : IRequestHandler<Queries.GetMonthList, List<MonthVM>>
    {
        public GetMonthListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<MonthVM>> Handle(Queries.GetMonthList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, MonthName"+"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<MonthVM>(query);
            return data.ToList();
        }
    }
}
