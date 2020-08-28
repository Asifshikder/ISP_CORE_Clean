using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.CableStock.Queries.Models
{
    public class CableStockVM
    {
        public int Id { get; set; }
        public int CableTypeID { get; set; }
        public int? BrandID { get; set; }
        public int? SupplierID { get; set; }
        public string SupplierInvoice { get; set; }
        public int FromReading { get; set; }
        public int ToReading { get; set; }
        public int CableUnitID { get; set; }
        public string CableBoxName { get; set; }
        public int CableQuantity { get; set; }
        public int UsedQuantityFromThisBox { get; set; }
        public int? TotallyUsed { get; set; }
        public int EmployeeID { get; set; }
        public int IndicatorStatus { get; set; }
    }
}
