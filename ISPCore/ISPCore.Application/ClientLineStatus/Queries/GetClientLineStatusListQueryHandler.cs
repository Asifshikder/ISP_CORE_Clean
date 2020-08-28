using Dapper;
using ISPCore.Application.ClientLineStatus.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ClientLineStatus.Queries
{
    public class GetClientLineStatusListQueryHandler : IRequestHandler<Queries.GetClientLineStatusList, List<ClientLineStatusVM>>
    {
        public GetClientLineStatusListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<ClientLineStatusVM>> Handle(Queries.GetClientLineStatusList request, CancellationToken cancellationToken)
        {
            var query = $"select Id,ClientDetailsID,PackageID,LineStatusID,LineStatusFromWhichMonth,StatusChangeReason,LineStatusChangeDate,EmployeeID,ResellerID,MikrotikID,IsLineStatusApplied,LineStatusWillActiveInThisDate,StatusFromNow,StatusThisMonth,StatusNextMonth,PackageThisMonth,PackageNextMonth" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<ClientLineStatusVM>(query);
            return data.ToList();
        }
    }
}
