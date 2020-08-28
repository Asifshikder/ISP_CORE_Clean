using Dapper;
using ISPCore.Application.Day.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Day.Queries
{
    public class GetDayQueryHandler : IRequestHandler<Queries.GetDay, DayVM>
    {
        public GetDayQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<DayVM> Handle(Queries.GetDay request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetDayById({request.DayId})";
            var query = $"SELECT * from Day where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<DayVM>(query);
            return data;
        }
    }
}
