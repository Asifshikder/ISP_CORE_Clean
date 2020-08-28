using Dapper;
using ISPCore.Application.Year.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Year.Queries
{
    public class GetYearQueryHandler : IRequestHandler<Queries.GetYear, YearVM>
    {
        public GetYearQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<YearVM> Handle(Queries.GetYear request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetYearById({request.YearId})";
            var query = $"SELECT * from Year where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<YearVM>(query);
            return data;
        }
    }
}
