using ISPCore.Application.ClientCableDistribution.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ClientCableDistribution.Queries
{
    public static class Queries
    {
        public class GetClientCableDistributionList : IRequest<List<ClientCableDistributionVM>>
        {
        }
        public class GetClientCableDistribution : IRequest<ClientCableDistributionVM>
        {
            public int Id { get; set; }
        }
    }
}
