using ISPCore.Application.PurchasePaymentHistory.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.PurchasePaymentHistory.Queries
{
    public static class Queries
    {
        public class GetPurchasePaymentHistoryList : IRequest<List<PurchasePaymentHistoryVM>>
        {
        }
        public class GetPurchasePaymentHistory : IRequest<PurchasePaymentHistoryVM>
        {
            public int Id { get; set; }
        }
    }
}
