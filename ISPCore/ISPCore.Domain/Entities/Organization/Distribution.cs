using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class Distribution : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }
        public int StockDetailsID { get; set; }
        public virtual StockDetails StockDetails { get; set; }
        public int? PopID { get; set; }
        public virtual Pop Pop { get; set; }
        public int? BoxID { get; set; }
        public virtual Box Box { get; set; }
        public int? ClientDetailsID { get; set; }
        public virtual ClientDetails ClientDetails { get; set; }
        public int? DistributionReasonID { get; set; }
        public virtual DistributionReason DistributionReason { get; set; }
        public int IndicatorStatus { get; set; }
        public string Remarks { get; set; }


        public int Status { get; private set; }


        public Distribution() { }

        public Distribution(  int employeeID , int stockDetailsID ,int? popID ,int? boxID,int? clientDetailsID , int? distributionReasonID , int indicatorStatus,  string remarks )
        {
            EmployeeID = employeeID;
            StockDetailsID = stockDetailsID;
            PopID = popID;
            ClientDetailsID = clientDetailsID;
            DistributionReasonID = distributionReasonID;
            IndicatorStatus = indicatorStatus;
            Remarks = remarks;
        }

        public void UpdateDistribution(int employeeID, int stockDetailsID, int? popID, int? boxID, int? clientDetailsID, int? distributionReasonID, int indicatorStatus,  string remarks)
        {
            EmployeeID = employeeID;
            StockDetailsID = stockDetailsID;
            PopID = popID;
            ClientDetailsID = clientDetailsID;
            DistributionReasonID = distributionReasonID;
            IndicatorStatus = indicatorStatus;
            Remarks = remarks;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
