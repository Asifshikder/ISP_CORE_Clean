using ISPCore.Application.ResellerBillingCycle.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ResellerBillingCycle.Queries
{
    public static class Queries
    {
        public class GetResellerBillingCycleList : IRequest<List<ResellerBillingCycleVM>>
        {
        }
        public class GetResellerBillingCycle : IRequest<ResellerBillingCycleVM>
        {
            public int Id { get; set; }
        }
    }
}
