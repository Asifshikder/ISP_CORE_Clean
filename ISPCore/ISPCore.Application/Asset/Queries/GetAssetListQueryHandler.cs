using Dapper;
using ISPCore.Application.Asset.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Asset.Queries
{
    public class GetAssetListQueryHandler : IRequestHandler<Queries.GetAssetList, List<AssetVM>>
    {
        public GetAssetListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<AssetVM>> Handle(Queries.GetAssetList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, AssetName, AssetTypeID,AssetValue,PurchaseDate,SerialNumber,WarrentyStartDate,WarrentyEndDate" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<AssetVM>(query);
            return data.ToList();
        }
    }
}
