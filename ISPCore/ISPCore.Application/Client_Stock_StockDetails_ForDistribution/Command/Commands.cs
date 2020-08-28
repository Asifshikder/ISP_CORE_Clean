using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Client_Stock_StockDetails_ForDistribution.Command
{
    public static class Commands
    {
        public static class Client_Stock_StockDetails_ForDistribution
        {
            public class Create : IRequest<Client_Stock_StockDetails_ForDistributionCommandVM>
            {
                public int StockID { get; set; }
                public int StockDetailsID { get; set; }
                public int? PopID { get; set; }
                public int? Client_Stock_StockDetails_ForDistributionID { get; set; }
                public int? CustomerID { get; set; }
                public int EmployeeID { get; set; }
                public int DistributionReasonID { get; set; }
                public int? OldStockID { get; set; }
                public int? OldStockDetailsID { get; set; }
                public int? OldSectionID { get; set; }
                public int? OldProductStatusID { get; set; }
                public string Remarks { get; set; }
            }

            public class Update : IRequest<Client_Stock_StockDetails_ForDistributionCommandVM>
            {
                public int Id { get; set; }
                public int StockID { get; set; }
                public int StockDetailsID { get; set; }
                public int? PopID { get; set; }
                public int? Client_Stock_StockDetails_ForDistributionID { get; set; }
                public int? CustomerID { get; set; }
                public int EmployeeID { get; set; }
                public int DistributionReasonID { get; set; }
                public int? OldStockID { get; set; }
                public int? OldStockDetailsID { get; set; }
                public int? OldSectionID { get; set; }
                public int? OldProductStatusID { get; set; }
                public string Remarks { get; set; }
            }

            public class MarkAsDelete : IRequest<Client_Stock_StockDetails_ForDistributionCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
