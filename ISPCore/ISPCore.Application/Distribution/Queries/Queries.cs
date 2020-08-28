using ISPCore.Application.Distribution.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Distribution.Queries
{
    public static class Queries
    {
        public class GetDistributionList : IRequest<List<DistributionVM>>
        {
        }
        public class GetDistribution : IRequest<DistributionVM>
        {
            public int Id { get; set; }
        }
    }
}
