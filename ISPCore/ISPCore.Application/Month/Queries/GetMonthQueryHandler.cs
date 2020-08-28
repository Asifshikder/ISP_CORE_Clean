using Dapper;
using ISPCore.Application.Month.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Month.Queries
{
    public class GetMonthQueryHandler : IRequestHandler<Queries.GetMonth, MonthVM>
    {
        public GetMonthQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<MonthVM> Handle(Queries.GetMonth request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetMonthById({request.MonthId})";
            var query = $"SELECT * from Month where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<MonthVM>(query);
            return data;
        }
    }
}
