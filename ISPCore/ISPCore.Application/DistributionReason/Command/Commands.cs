using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.DistributionReason.Command
{
    public static class Commands
    {
        public static class DistributionReason
        {
            public class Create : IRequest<DistributionReasonCommandVM>
            {
                public string DistributionReasonName { get; set; }
            }

            public class Update : IRequest<DistributionReasonCommandVM>
            {
                public int Id { get; set; }
                public string DistributionReasonName { get; set; }
            }

            public class MarkAsDelete : IRequest<DistributionReasonCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
