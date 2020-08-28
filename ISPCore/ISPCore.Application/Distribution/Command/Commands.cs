using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Distribution.Command
{
    public static class Commands
    {
        public static class Distribution
        {
            public class Create : IRequest<DistributionCommandVM>
            {
                public int EmployeeID { get; set; }
                public int StockDetailsID { get; set; }
                public int? PopID { get; set; }
                public int? BoxID { get; set; }
                public int? ClientDetailsID { get; set; }
                public int? DistributionReasonID { get; set; }
                public int IndicatorStatus { get; set; }
                public string Remarks { get; set; }
            }

            public class Update : IRequest<DistributionCommandVM>
            {
                public int Id { get; set; }
                public int EmployeeID { get; set; }
                public int StockDetailsID { get; set; }
                public int? PopID { get; set; }
                public int? BoxID { get; set; }
                public int? ClientDetailsID { get; set; }
                public int? DistributionReasonID { get; set; }
                public int IndicatorStatus { get; set; }
                public string Remarks { get; set; }
            }

            public class MarkAsDelete : IRequest<DistributionCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
