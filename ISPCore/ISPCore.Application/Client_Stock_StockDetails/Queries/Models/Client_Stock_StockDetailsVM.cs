using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Client_Stock_StockDetails.Queries.Models
{
    public class Client_Stock_StockDetailsVM
    {
        public int Id { get; set; }
        public int StockID { get; set; }
        public int StockDetailsID { get; set; }
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public int BrandID { get; set; }
        public string BrandName { get; set; }
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string SupplierInvoice { get; set; }
        public string Serial { get; set; }
        public bool WarrentyProduct { get; set; }
    }
}
