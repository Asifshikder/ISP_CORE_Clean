using ISPCore.Application.DistributionReason.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.DistributionReason.Queries
{
    public static class Queries
    {
        public class GetDistributionReasonList : IRequest<List<DistributionReasonVM>>
        {
        }
        public class GetDistributionReason : IRequest<DistributionReasonVM>
        {
            public int Id { get; set; }
        }
    }
}
