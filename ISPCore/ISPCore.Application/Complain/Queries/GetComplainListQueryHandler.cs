using Dapper;
using ISPCore.Application.Complain.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Complain.Queries
{
    public class GetComplainListQueryHandler : IRequestHandler<Queries.GetComplainList, List<ComplainVM>>
    {
        public GetComplainListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<ComplainVM>> Handle(Queries.GetComplainList request, CancellationToken cancellationToken)
        {
            var query = $"select Id,  ClientDetailsID, TokenNo, MonthlySerialNo, ComplainDetails, EmployeeID, ResellerID, LineStatusID, ComplainTypeID, WhichOrWhere, ComplainOpenBy, ComplainTime, OnRequest" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<ComplainVM>(query);
            return data.ToList();
        }
    }
}
