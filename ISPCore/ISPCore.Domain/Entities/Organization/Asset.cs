using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class Asset : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public string AssetName { get; set; }
        public int AssetTypeID { get; set; }
        public virtual AssetType AssetType { get; set; }
        public double AssetValue { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string SerialNumber { get; set; }
        public DateTime? WarrentyStartDate { get; set; }
        public DateTime? WarrentyEndDate { get; set; }

        public int Status { get; private set; }

        public Asset() { }

        public Asset(string assetName, int assetTypeID, double assetValue, DateTime purchaseDate, string serialNumber, DateTime? warrentyStartDate, DateTime? warrentyEndDate)
        {
            AssetName = assetName;
            AssetTypeID = assetTypeID;
            PurchaseDate = purchaseDate;
            SerialNumber = serialNumber;
            WarrentyStartDate = warrentyStartDate;
            WarrentyEndDate = warrentyEndDate;
        }

        public void UpdateAsset(string assetName, int assetTypeID, double assetValue, DateTime purchaseDate, string serialNumber, DateTime? warrentyStartDate, DateTime? warrentyEndDate)
        {
            AssetName = assetName;
            AssetTypeID = assetTypeID;
            PurchaseDate = purchaseDate;
            SerialNumber = serialNumber;
            WarrentyStartDate = warrentyStartDate;
            WarrentyEndDate = warrentyEndDate;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
