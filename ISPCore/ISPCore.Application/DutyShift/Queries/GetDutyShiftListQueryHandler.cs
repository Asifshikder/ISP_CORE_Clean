using Dapper;
using ISPCore.Application.DutyShift.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.DutyShift.Queries
{
    public class GetDutyShiftListQueryHandler : IRequestHandler<Queries.GetDutyShiftList, List<DutyShiftVM>>
    {
        public GetDutyShiftListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<DutyShiftVM>> Handle(Queries.GetDutyShiftList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, StartHour,StartMinute,EndHour, EndMinute" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<DutyShiftVM>(query);
            return data.ToList();
        }
    }
}
