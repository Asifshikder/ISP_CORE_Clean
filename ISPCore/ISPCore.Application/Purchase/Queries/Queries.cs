using ISPCore.Application.Purchase.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Purchase.Queries
{
    public static class Queries
    {
        public class GetPurchaseList : IRequest<List<PurchaseVM>>
        {
        }
        public class GetPurchase : IRequest<PurchaseVM>
        {
            public int Id { get; set; }
        }
    }
}
