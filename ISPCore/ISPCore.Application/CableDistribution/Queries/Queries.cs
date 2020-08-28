using ISPCore.Application.CableDistribution.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.CableDistribution.Queries
{
    public static class Queries
    {
        public class GetCableDistributionList : IRequest<List<CableDistributionVM>>
        {
        }
        public class GetCableDistribution : IRequest<CableDistributionVM>
        {
            public int Id { get; set; }
        }
    }
}
