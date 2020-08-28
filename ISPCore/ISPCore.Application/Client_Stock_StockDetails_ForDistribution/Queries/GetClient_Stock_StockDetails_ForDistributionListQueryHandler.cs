using Dapper;
using ISPCore.Application.Client_Stock_StockDetails_ForDistribution.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Client_Stock_StockDetails_ForDistribution.Queries
{
    public class GetClient_Stock_StockDetails_ForDistributionListQueryHandler : IRequestHandler<Queries.GetClient_Stock_StockDetails_ForDistributionList, List<Client_Stock_StockDetails_ForDistributionVM>>
    {
        public GetClient_Stock_StockDetails_ForDistributionListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<Client_Stock_StockDetails_ForDistributionVM>> Handle(Queries.GetClient_Stock_StockDetails_ForDistributionList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, ,StockID,,StockDetailsID,,PopID,,Client_Stock_StockDetails_ForDistributionID,,CustomerID,,EmployeeID,,DistributionReasonID,,OldStockID,,OldStockDetailsID,,OldSectionID,,OldProductStatusID,,Remarks" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<Client_Stock_StockDetails_ForDistributionVM>(query);
            return data.ToList();
        }
    }
}
