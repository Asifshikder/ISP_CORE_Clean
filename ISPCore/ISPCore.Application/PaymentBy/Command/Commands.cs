using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.PaymentBy.Command
{
    public static class Commands
    {
        public static class PaymentBy
        {
            public class Create : IRequest<PaymentByCommandVM>
            {
                public string PaymentByName { get; set; }
            }

            public class Update : IRequest<PaymentByCommandVM>
            {
                public int Id { get; set; }
                public string PaymentByName { get; set; }
            }

            public class MarkAsDelete : IRequest<PaymentByCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
