using Dapper;
using ISPCore.Application.Reseller.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Reseller.Queries
{
    public class GetResellerListQueryHandler : IRequestHandler<Queries.GetResellerList, List<ResellerVM>>
    {
        public GetResellerListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<ResellerVM>> Handle(Queries.GetResellerList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, ResellerName,ResellerName,ResellerLoginName,ResellerBusinessName,ResellerPassword,ResellerTypeListID,ResellerAddress,ResellerContact,ResellerBillingCycleList,ResellerLogo,ResellerLogoPath,BandwithReselleItemGivenWithPrice,MacReselleGivenPackageWithPrice,ResellerBalance,RoleID,UserRightPermissionID,MacResellerAssignMikrotik"+"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<ResellerVM>(query);
            return data.ToList();
        }
    }
}
