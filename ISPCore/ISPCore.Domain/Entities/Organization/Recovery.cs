﻿using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class Recovery : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }
        public int DistributionReasonID { get; set; }
        public virtual DistributionReason DistributionReason { get; set; }
        public int DistributionID { get; set; }
        public virtual Distribution Distribution { get; set; }
        public int StockDetailsID { get; set; }
        public virtual StockDetails StockDetails { get; set; }
        public int? PopID { get; set; }
        public virtual Pop Pop { get; set; }
        public int? BoxID { get; set; }
        public virtual Box Box { get; set; }
        public int? ClientDetailsID { get; set; }
        public virtual ClientDetails ClientDetails { get; set; }
        public DateTime RecoveryDate { get; set; }
        public int IndicatorStatus { get; set; }

        public int Status { get; private set; }


        public Recovery() { }

        public Recovery(int employeeID,int distributionReasonID,int distributionID ,int stockDetailsID, int? popID ,int? boxID,
            int? clientDetailsID,DateTime recoveryDate,int indicatorStatus )
        {
            EmployeeID = employeeID;
            DistributionReasonID = distributionReasonID;
            DistributionID = distributionReasonID;
            PopID = popID;
            BoxID = boxID;
            ClientDetailsID = clientDetailsID;
            RecoveryDate = recoveryDate;
            IndicatorStatus = indicatorStatus;
        }

        public void UpdateRecovery(int employeeID, int distributionReasonID, int distributionID, int stockDetailsID, int? popID, int? boxID,
            int? clientDetailsID, DateTime recoveryDate, int indicatorStatus)
        {
            EmployeeID = employeeID;
            DistributionReasonID = distributionReasonID;
            DistributionID = distributionReasonID;
            PopID = popID;
            BoxID = boxID;
            ClientDetailsID = clientDetailsID;
            RecoveryDate = recoveryDate;
            IndicatorStatus = indicatorStatus;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
