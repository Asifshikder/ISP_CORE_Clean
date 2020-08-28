using ISPCore.Application.AssetType.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.AssetType.Queries
{
    public static class Queries
    {
        public class GetAssetTypeList : IRequest<List<AssetTypeVM>>
        {
        }
        public class GetAssetType : IRequest<AssetTypeVM>
        {
            public int Id { get; set; }
        }
    }
}
