using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ResellerVsPackageHistory.Command
{
    public static class Commands
    {
        public static class ResellerVsPackageHistory
        {
            public class Create : IRequest<ResellerVsPackageHistoryCommandVM>
            {
                public int ResellerID { get; set; }
                public int ResellerName { get; set; }
                public int ResellerPackageID { get; set; }
                public string PackageName { get; set; }
                public string PackagePrice { get; set; }
            }

            public class Update : IRequest<ResellerVsPackageHistoryCommandVM>
            {
                public int Id { get; set; }
                public int ResellerID { get; set; }
                public int ResellerName { get; set; }
                public int ResellerPackageID { get; set; }
                public string PackageName { get; set; }
                public string PackagePrice { get; set; }
            }

            public class MarkAsDelete : IRequest<ResellerVsPackageHistoryCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
