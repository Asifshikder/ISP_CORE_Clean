using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Client_Stock_StockDetails_ForDistribution.Queries.Models
{
    public class Client_Stock_StockDetails_ForDistributionVM
    {
        public int Id { get; set; }
        public int StockID { get; set; }
        public int StockDetailsID { get; set; }
        public int? PopID { get; set; }
        public int? Client_Stock_StockDetails_ForDistributionID { get; set; }
        public int? CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public int DistributionReasonID { get; set; }
        public int? OldStockID { get; set; }
        public int? OldStockDetailsID { get; set; }
        public int? OldSectionID { get; set; }
        public int? OldProductStatusID { get; set; }
        public string Remarks { get; set; }
    }
}
