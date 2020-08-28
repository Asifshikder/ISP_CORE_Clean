using ISPCore.Application.ResellerPaymentDetailsHistory.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ResellerPaymentDetailsHistory.Queries
{
    public static class Queries
    {
        public class GetResellerPaymentDetailsHistoryList : IRequest<List<ResellerPaymentDetailsHistoryVM>>
        {
        }
        public class GetResellerPaymentDetailsHistory : IRequest<ResellerPaymentDetailsHistoryVM>
        {
            public int Id { get; set; }
        }
    }
}
