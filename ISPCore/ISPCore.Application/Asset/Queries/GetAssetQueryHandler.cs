using Dapper;
using ISPCore.Application.Asset.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Asset.Queries
{
    public class GetAssetQueryHandler : IRequestHandler<Queries.GetAsset, AssetVM>
    {
        public GetAssetQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<AssetVM> Handle(Queries.GetAsset request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetAssetById({request.AssetId})";
            var query = $"SELECT * from Asset where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<AssetVM>(query);
            return data;
        }
    }
}
