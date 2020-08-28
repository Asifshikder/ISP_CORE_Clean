using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class AssetType : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public string AssetTypeName { get; private set; }

        public int Status { get; private set; }


        public AssetType() { }

        public AssetType(string assetTypeName)
        {
            AssetTypeName = assetTypeName;
        }

        public void UpdateAssetType(string assetTypeName)
        {
            AssetTypeName = assetTypeName;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
