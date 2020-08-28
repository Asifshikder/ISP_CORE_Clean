using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Asset.Queries.Models
{
    public class AssetVM
    {
        public int Id { get; set; } 
        public string AssetName { get; set; }
        public int AssetTypeID { get; set; }
        public double AssetValue { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string SerialNumber { get; set; }
        public DateTime? WarrentyStartDate { get; set; }
        public DateTime? WarrentyEndDate { get; set; }
    }
}
