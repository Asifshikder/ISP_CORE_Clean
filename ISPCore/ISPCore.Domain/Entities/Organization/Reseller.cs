using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class Reseller : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public string ResellerName { get; set; }
        public string ResellerLoginName { get; set; }
        public string ResellerBusinessName { get; set; }
        public string ResellerPassword { get; set; }
        public string ResellerTypeListID { get; set; }//cause there is a possibilities that a reseller has a mac and bandwidth client
        public string ResellerAddress { get; set; }
        public string ResellerContact { get; set; }
        public string ResellerBillingCycleList { get; set; }
        public byte[] ResellerLogo { get; set; }
        public string ResellerLogoPath { get; set; }
        //[NotMapped]
        //public virtual List<bandwithReselleGivenItemWithPriceModel> bandwithReselleGivenItemWithPriceModel { get; set; }
        public string BandwithReselleItemGivenWithPrice { get; set; }
        //[NotMapped]
        //public virtual List<macReselleGivenPackageWithPriceModel> macResellerGivenPackagePriceModel { get; set; }
        public string MacReselleGivenPackageWithPrice { get; set; }
        public double ResellerBalance { get; set; }
        public int? RoleID { get; set; }
        public virtual Role Role { get; set; }
        public int? UserRightPermissionID { get; set; }
        public virtual UserRightPermission UserRightPermission { get; set; }
        public string MacResellerAssignMikrotik { get; set; }

        public int Status { get; set; }

        public Reseller() { }

        public Reseller(string resellerName, string resellerLoginName, string resellerBusinessName, string resellerPassword, string resellerTypeListID,string resellerAddress,string resellerContact,
            string resellerBillingCycleList,byte[] resellerLogo, string resellerLogoPath,string bandwithReselleItemGivenWithPrice,string macReselleGivenPackageWithPrice,double resellerBalance,
            int? roleID, int? userRightPermissionID,string macResellerAssignMikrotik
            )
        {
            ResellerName = resellerName;
            ResellerLoginName = resellerLoginName;
            ResellerBusinessName = resellerBusinessName;
            ResellerPassword = resellerPassword;
            ResellerTypeListID = resellerTypeListID;
            ResellerAddress = resellerAddress;
            ResellerContact = resellerContact;
            ResellerBillingCycleList = resellerBillingCycleList;
            ResellerLogo = resellerLogo;
            ResellerLogoPath = resellerLogoPath;
            BandwithReselleItemGivenWithPrice = bandwithReselleItemGivenWithPrice;
            MacReselleGivenPackageWithPrice = macReselleGivenPackageWithPrice;
            ResellerBalance = resellerBalance;
            RoleID = roleID;
            UserRightPermissionID = userRightPermissionID;
            MacResellerAssignMikrotik = macResellerAssignMikrotik;
        }

        public void UpdateReseller(string resellerName, string resellerLoginName, string resellerBusinessName, string resellerPassword, string resellerTypeListID, string resellerAddress, string resellerContact,
            string resellerBillingCycleList, byte[] resellerLogo, string resellerLogoPath, string bandwithReselleItemGivenWithPrice, string macReselleGivenPackageWithPrice, double resellerBalance,
            int? roleID, int? userRightPermissionID, string macResellerAssignMikrotik
            )
        {
            ResellerName = resellerName;
            ResellerLoginName = resellerLoginName;
            ResellerBusinessName = resellerBusinessName;
            ResellerPassword = resellerPassword;
            ResellerTypeListID = resellerTypeListID;
            ResellerAddress = resellerAddress;
            ResellerContact = resellerContact;
            ResellerBillingCycleList = resellerBillingCycleList;
            ResellerLogo = resellerLogo;
            ResellerLogoPath = resellerLogoPath;
            BandwithReselleItemGivenWithPrice = bandwithReselleItemGivenWithPrice;
            MacReselleGivenPackageWithPrice = macReselleGivenPackageWithPrice;
            ResellerBalance = resellerBalance;
            RoleID = roleID;
            UserRightPermissionID = userRightPermissionID;
            MacResellerAssignMikrotik = macResellerAssignMikrotik; ;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
