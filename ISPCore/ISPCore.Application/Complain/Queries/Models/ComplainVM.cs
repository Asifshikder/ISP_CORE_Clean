using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Complain.Queries.Models
{
    public class ComplainVM
    {
        public int Id { get; set; }
        public int ClientDetailsID { get; set; }
        public int TokenNo { get; set; }
        public string MonthlySerialNo { get; set; }
        public string ComplainDetails { get; set; }
        public int? EmployeeID { get; set; }
        public int? ResellerID { get; set; }
        public int LineStatusID { get; set; }
        public int ComplainTypeID { get; set; }
        public string WhichOrWhere { get; set; }
        public int ComplainOpenBy { get; set; }
        public DateTime ComplainTime { get; set; }
        public bool OnRequest { get; set; }
    }
}
