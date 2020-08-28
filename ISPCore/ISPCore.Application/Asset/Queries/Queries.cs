using ISPCore.Application.Asset.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Asset.Queries
{
    public static class Queries
    {
        public class GetAssetList : IRequest<List<AssetVM>>
        {
        }
        public class GetAsset : IRequest<AssetVM>
        {
            public int Id { get; set; }
        }
    }
}
