using Dapper;
using ISPCore.Application.TimePeriodForSignal.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.TimePeriodForSignal.Queries
{
    public class GetTimePeriodForSignalQueryHandler : IRequestHandler<Queries.GetTimePeriodForSignal, TimePeriodForSignalVM>
    {
        public GetTimePeriodForSignalQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<TimePeriodForSignalVM> Handle(Queries.GetTimePeriodForSignal request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetTimePeriodForSignalById({request.TimePeriodForSignalId})";
            var query = $"SELECT * from TimePeriodForSignal where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<TimePeriodForSignalVM>(query);
            return data;
        }
    }
}
