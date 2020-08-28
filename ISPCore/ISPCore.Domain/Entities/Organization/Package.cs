using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class Package : BaseEntity, IHasId<int>, IAggregateRoot
    {
        //public int PackageID { get; set; }
        public int Id { get; private set; }
        public string PackageName { get; set; }
        public int? IPPoolID { get; set; }
        public virtual IPPool IpPool { get; set; }
        public int? MikrotikID { get; set; }
        public virtual Mikrotik Mikrotik { get; set; }
        public string LocalAddress { get; set; }
        public string OldPackageName { get; set; }
        public float PackagePrice { get; set; }
        public string BandWith { get; set; }
        public int Status { get; private set; }

        public Package() { }

        public Package(string packageName, int? iPPoolID, int? mikrotikID,string localAddress,string oldPackageName, float packagePrice,string bandWith)
        {
            PackageName = packageName;
            IPPoolID = iPPoolID;
            MikrotikID = mikrotikID;
            LocalAddress = localAddress;
            OldPackageName = oldPackageName;
            PackagePrice = packagePrice;
            BandWith = bandWith;
        }

        public void UpdatePackage(string packageName, int? iPPoolID, int? mikrotikID, string localAddress, string oldPackageName, float packagePrice, string bandWith)
        {
            PackageName = packageName;
            IPPoolID = iPPoolID;
            MikrotikID = mikrotikID;
            LocalAddress = localAddress;
            OldPackageName = oldPackageName;
            PackagePrice = packagePrice;
            BandWith = bandWith;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
