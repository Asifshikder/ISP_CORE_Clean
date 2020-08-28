using ISPCore.Application.ResellerVsPackageHistory.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ResellerVsPackageHistory.Queries
{
    public static class Queries
    {
        public class GetResellerVsPackageHistoryList : IRequest<List<ResellerVsPackageHistoryVM>>
        {
        }
        public class GetResellerVsPackageHistory : IRequest<ResellerVsPackageHistoryVM>
        {
            public int Id { get; set; }
        }
    }
}
