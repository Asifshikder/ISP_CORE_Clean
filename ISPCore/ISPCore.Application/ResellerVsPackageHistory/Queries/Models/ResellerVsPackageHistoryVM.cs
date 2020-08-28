using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ResellerVsPackageHistory.Queries.Models
{
    public class ResellerVsPackageHistoryVM
    {
        public int Id { get; set; }
        public int ResellerID { get; set; }
        public int ResellerName { get; set; }
        public int ResellerPackageID { get; set; }
        public string PackageName { get; set; }
        public string PackagePrice { get; set; }
    }
}
