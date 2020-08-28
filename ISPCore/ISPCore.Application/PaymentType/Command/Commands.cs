using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.PaymentType.Command
{
    public static class Commands
    {
        public static class PaymentType
        {
            public class Create : IRequest<PaymentTypeCommandVM>
            {
                public string PaymentTypeName { get; set; }
            }

            public class Update : IRequest<PaymentTypeCommandVM>
            {
                public int Id { get; set; }
                public string PaymentTypeName { get; set; }
            }

            public class MarkAsDelete : IRequest<PaymentTypeCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
