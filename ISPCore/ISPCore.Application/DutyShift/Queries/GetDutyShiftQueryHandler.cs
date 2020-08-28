using Dapper;
using ISPCore.Application.DutyShift.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.DutyShift.Queries
{
    public class GetDutyShiftQueryHandler : IRequestHandler<Queries.GetDutyShift, DutyShiftVM>
    {
        public GetDutyShiftQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<DutyShiftVM> Handle(Queries.GetDutyShift request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetDutyShiftById({request.DutyShiftId})";
            var query = $"SELECT * from DutyShift where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<DutyShiftVM>(query);
            return data;
        }
    }
}
