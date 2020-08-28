using Dapper;
using ISPCore.Application.AssetType.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.AssetType.Queries
{
    public class GetAssetTypeListQueryHandler : IRequestHandler<Queries.GetAssetTypeList, List<AssetTypeVM>>
    {
        public GetAssetTypeListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<AssetTypeVM>> Handle(Queries.GetAssetTypeList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, AssetTypeName"+"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<AssetTypeVM>(query);
            return data.ToList();
        }
    }
}
