using ISPCore.Application.PurchaseDetails.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.PurchaseDetails.Queries
{
    public static class Queries
    {
        public class GetPurchaseDetailsList : IRequest<List<PurchaseDetailsVM>>
        {
        }
        public class GetPurchaseDetails : IRequest<PurchaseDetailsVM>
        {
            public int Id { get; set; }
        }
    }
}
