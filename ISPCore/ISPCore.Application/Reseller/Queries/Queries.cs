using ISPCore.Application.Reseller.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Reseller.Queries
{
    public static class Queries
    {
        public class GetResellerList : IRequest<List<ResellerVM>>
        {
        }
        public class GetReseller : IRequest<ResellerVM>
        {
            public int Id { get; set; }
        }
    }
}
