using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.PaymentFrom.Command
{
    public static class Commands
    {
        public static class PaymentFrom
        {
            public class Create : IRequest<PaymentFromCommandVM>
            {
                public string PaymentFromName { get; set; }
            }

            public class Update : IRequest<PaymentFromCommandVM>
            {
                public int Id { get; set; }
                public string PaymentFromName { get; set; }
            }

            public class MarkAsDelete : IRequest<PaymentFromCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
