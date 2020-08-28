using Dapper;
using ISPCore.Application.AssetType.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.AssetType.Queries
{
    public class GetAssetTypeQueryHandler : IRequestHandler<Queries.GetAssetType, AssetTypeVM>
    {
        public GetAssetTypeQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<AssetTypeVM> Handle(Queries.GetAssetType request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetAssetTypeById({request.AssetTypeId})";
            var query = $"SELECT * from AssetType where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<AssetTypeVM>(query);
            return data;
        }
    }
}
