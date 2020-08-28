using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.StockDetails.Queries.Models
{
    public class StockDetailsVM
    {
        public int Id { get; set; }
        public int StockID { get; set; }
        public int? BrandID { get; set; }
        public int SectionID { get; set; }
        public int? SupplierID { get; set; }
        public string SupplierInvoice { get; set; }
        public string Serial { get; set; }
        public string BarCode { get; set; }
        public int ProductStatusID { get; set; }
        public bool WarrentyProduct { get; set; }
    }
}
