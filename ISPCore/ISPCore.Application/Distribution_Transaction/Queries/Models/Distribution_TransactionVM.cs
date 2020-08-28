using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Distribution_Transaction.Queries.Models
{
    public class Distribution_TransactionVM
    {
        public int Id { get; set; }
        public int StockDetailsID { get; set; }
        public int SectionID { get; set; }
        public int ProductStatusID { get; set; }
        public string ItemName { get; set; }
        public string BrandName { get; set; }
        public string Serial { get; set; }
        public string ClientName { get; set; }
        public string EmployeeName { get; set; }
        public string SectionName { get; set; }
        public string ProductStatus { get; set; }
    }
}
