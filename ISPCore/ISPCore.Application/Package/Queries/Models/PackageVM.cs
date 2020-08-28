using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Package.Queries.Models
{
    public class PackageVM
    {
        public int Id { get; set; } 
        public string PackageName { get; set; }
        public int? IPPoolID { get; set; }
        public int? MikrotikID { get; set; }
        public string LocalAddress { get; set; }
        public string OldPackageName { get; set; }
        public float PackagePrice { get; set; }
        public string BandWith { get; set; }
    }
}
