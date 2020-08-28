using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Recovery.Queries.Models
{
    public class RecoveryVM
    {
        public int Id { get; set; }
        public int EmployeeID { get; set; }
        public int DistributionReasonID { get; set; }
        public int DistributionID { get; set; }
        public int StockDetailsID { get; set; }
        public int? PopID { get; set; }
        public int? BoxID { get; set; }
        public int? ClientDetailsID { get; set; }
        public DateTime RecoveryDate { get; set; }
        public int IndicatorStatus { get; set; }
    }
}
