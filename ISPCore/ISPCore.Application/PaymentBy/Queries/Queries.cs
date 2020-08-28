using ISPCore.Application.PaymentBy.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.PaymentBy.Queries
{
    public static class Queries
    {
        public class GetPaymentByList : IRequest<List<PaymentByVM>>
        {
        }
        public class GetPaymentBy : IRequest<PaymentByVM>
        {
            public int Id { get; set; }
        }
    }
}
