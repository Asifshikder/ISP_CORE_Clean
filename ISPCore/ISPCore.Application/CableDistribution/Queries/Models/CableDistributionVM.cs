using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.CableDistribution.Queries.Models
{
    public class CableDistributionVM
    {
        public int Id { get; set; }
        public int? ClientDetailsID { get; set; }
        public int? EmployeeID { get; set; }
        public int? CableForEmployeeID { get; set; }
        public int CableStockID { get; set; }
        public int AmountOfCableUsed { get; set; }
        public string Purpose { get; set; }
        public int CableAssignFromWhere { get; set; }
        public int CableIndicatorStatus { get; set; }
        public string Remarks { get; set; }
        public int Status { get; private set; }
    }
}
