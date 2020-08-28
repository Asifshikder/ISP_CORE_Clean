using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Asset.Command
{
    public static class Commands
    {
        public static class Asset
        {
            public class Create : IRequest<AssetCommandVM>
            {
                public string AssetName { get; set; }
                public int AssetTypeID { get; set; }
                public double AssetValue { get; set; }
                public DateTime PurchaseDate { get; set; }
                public string SerialNumber { get; set; }
                public DateTime? WarrentyStartDate { get; set; }
                public DateTime? WarrentyEndDate { get; set; }
            }

            public class Update : IRequest<AssetCommandVM>
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

            public class MarkAsDelete : IRequest<AssetCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
