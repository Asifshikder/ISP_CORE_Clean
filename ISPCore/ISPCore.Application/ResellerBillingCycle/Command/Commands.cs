using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ResellerBillingCycle.Command
{
    public static class Commands
    {
        public static class ResellerBillingCycle
        {
            public class Create : IRequest<ResellerBillingCycleCommandVM>
            {

                public int Day { get; set; }
            }

            public class Update : IRequest<ResellerBillingCycleCommandVM>
            {
                public int Id { get; set; }

                public int Day { get; set; }
            }

            public class MarkAsDelete : IRequest<ResellerBillingCycleCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
