using ISPCore.Application.Recovery.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Recovery.Queries
{
    public static class Queries
    {
        public class GetRecoveryList : IRequest<List<RecoveryVM>>
        {
        }
        public class GetRecovery : IRequest<RecoveryVM>
        {
            public int Id { get; set; }
        }
    }
}
