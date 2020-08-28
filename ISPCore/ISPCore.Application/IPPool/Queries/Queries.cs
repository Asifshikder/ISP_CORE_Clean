using ISPCore.Application.IPPool.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.IPPool.Queries
{
    public static class Queries
    {
        public class GetIPPoolList : IRequest<List<IPPoolVM>>
        {
        }
        public class GetIPPool : IRequest<IPPoolVM>
        {
            public int Id { get; set; }
        }
    }
}
