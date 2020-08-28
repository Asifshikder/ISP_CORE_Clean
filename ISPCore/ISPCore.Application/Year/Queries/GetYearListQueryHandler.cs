using Dapper;
using ISPCore.Application.Year.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Year.Queries
{
    public class GetYearListQueryHandler : IRequestHandler<Queries.GetYearList, List<YearVM>>
    {
        public GetYearListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<YearVM>> Handle(Queries.GetYearList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, YearName"+"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<YearVM>(query);
            return data.ToList();
        }
    }
}
