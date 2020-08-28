using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.AdvancePayment.Command
{
    public static class Commands
    {
        public static class AdvancePayment
        {
            public class Create : IRequest<AdvancePaymentCommandVM>
            {
                public int ClientDetailsID { get; set; }
                public double AdvanceAmount { get; set; }
                public string Remarks { get; set; }
                public string CollectBy { get; set; }
            }

            public class Update : IRequest<AdvancePaymentCommandVM>
            {
                public int Id { get; set; }
                public int ClientDetailsID { get; set; }
                public double AdvanceAmount { get; set; }
                public string Remarks { get; set; }
                public string CollectBy { get; set; }
            }

            public class MarkAsDelete : IRequest<AdvancePaymentCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
