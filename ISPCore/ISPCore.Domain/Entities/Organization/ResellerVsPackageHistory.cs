using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class ResellerVsPackageHistory : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public int ResellerID { get; set; }
        public virtual Reseller Reseller { get; set; }
        public int ResellerName { get; set; }
        public int ResellerPackageID { get; set; }
        public string PackageName { get; set; }
        public string PackagePrice { get; set; }

        public int Status { get; private set; }

        public ResellerVsPackageHistory() { }

        public ResellerVsPackageHistory(int resellerID ,int resellerName,int resellerPackageID,string packageName,string packagePrice)
        {
            ResellerID = resellerID;
            ResellerName = resellerName;
            ResellerPackageID = resellerPackageID;
            PackageName = packageName;
            PackagePrice = packagePrice;

        }

        public void UpdateResellerVsPackageHistory(int resellerID, int resellerName, int resellerPackageID, string packageName, string packagePrice)
        {
            ResellerID = resellerID;
            ResellerName = resellerName;
            ResellerPackageID = resellerPackageID;
            PackageName = packageName;
            PackagePrice = packagePrice;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
