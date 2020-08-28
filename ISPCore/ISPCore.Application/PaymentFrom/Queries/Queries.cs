using ISPCore.Application.PaymentFrom.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.PaymentFrom.Queries
{
    public static class Queries
    {
        public class GetPaymentFromList : IRequest<List<PaymentFromVM>>
        {
        }
        public class GetPaymentFrom : IRequest<PaymentFromVM>
        {
            public int Id { get; set; }
        }
    }
}
