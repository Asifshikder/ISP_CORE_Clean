using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Reseller.Queries.Models
{
    public class ResellerVM
    {
        public int Id { get; set; }
        public string ResellerLoginName { get; set; }
        public string ResellerBusinessName { get; set; }
        public string ResellerPassword { get; set; }
        public string ResellerTypeListID { get; set; }//cause there is a possibilities that a reseller has a mac and bandwidth client
        public string ResellerAddress { get; set; }
        public string ResellerContact { get; set; }
        public string ResellerBillingCycleList { get; set; }
        public byte[] ResellerLogo { get; set; }
        public string ResellerLogoPath { get; set; }
        public string BandwithReselleItemGivenWithPrice { get; set; }
        public string MacReselleGivenPackageWithPrice { get; set; }
        public double ResellerBalance { get; set; }
        public int? RoleID { get; set; }
        public int? UserRightPermissionID { get; set; }
        public string MacResellerAssignMikrotik { get; set; }
    }
}
