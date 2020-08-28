using ISPCore.Application.PaymentType.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.PaymentType.Queries
{
    public static class Queries
    {
        public class GetPaymentTypeList : IRequest<List<PaymentTypeVM>>
        {
        }
        public class GetPaymentType : IRequest<PaymentTypeVM>
        {
            public int Id { get; set; }
        }
    }
}
