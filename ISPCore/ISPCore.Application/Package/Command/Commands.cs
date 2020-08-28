using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Package.Command
{
    public static class Commands
    {
        public static class Package
        {
            public class Create : IRequest<PackageCommandVM>
            {
                public string PackageName { get; set; }

                public int? IPPoolID { get; set; }
                public int? MikrotikID { get; set; }
                public string LocalAddress { get; set; }
                public string OldPackageName { get; set; }
                public float PackagePrice { get; set; }
                public string BandWith { get; set; }
            }

            public class Update : IRequest<PackageCommandVM>
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

            public class MarkAsDelete : IRequest<PackageCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
