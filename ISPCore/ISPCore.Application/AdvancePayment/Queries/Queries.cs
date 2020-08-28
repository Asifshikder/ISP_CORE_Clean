using ISPCore.Application.AdvancePayment.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.AdvancePayment.Queries
{
    public static class Queries
    {
        public class GetAdvancePaymentList : IRequest<List<AdvancePaymentVM>>
        {
        }
        public class GetAdvancePayment : IRequest<AdvancePaymentVM>
        {
            public int Id { get; set; }
        }
    }
}
