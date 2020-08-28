using Dapper;
using ISPCore.Application.BandwithResellerGivenItem.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.BandwithResellerGivenItem.Queries
{
    public class GetBandwithResellerGivenItemListQueryHandler : IRequestHandler<Queries.GetBandwithResellerGivenItemList, List<BandwithResellerGivenItemVM>>
    {
        public GetBandwithResellerGivenItemListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<BandwithResellerGivenItemVM>> Handle(Queries.GetBandwithResellerGivenItemList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, ItemName,MeasureUnit,PerUnitCommonPrice" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<BandwithResellerGivenItemVM>(query);
            return data.ToList();
        }
    }
}
