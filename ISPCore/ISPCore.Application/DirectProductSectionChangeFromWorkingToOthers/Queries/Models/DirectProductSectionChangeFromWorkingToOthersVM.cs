using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.DirectProductSectionChangeFromWorkingToOthers.Queries.Models
{
    public class DirectProductSectionChangeFromWorkingToOthersVM
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string TakenEmployee { get; set; }
        public int StockDetailsID { get; set; }
        public int FromSection { get; set; }
        public int ToSection { get; set; }
        public string WhoChanged { get; set; }
        public DateTime ChangeDateTime { get; set; }
    }
}
