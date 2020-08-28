using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class CableDistribution : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public int? ClientDetailsID { get; set; }
        public virtual ClientDetails ClientDetails { get; set; }
        public int? EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }
        public int? CableForEmployeeID { get; set; }
        public int CableStockID { get; set; }
        public virtual CableStock CableStock { get; set; }
        public int AmountOfCableUsed { get; set; }
        public string Purpose { get; set; }
        public int CableAssignFromWhere { get; set; }
        public int CableIndicatorStatus { get; set; }
        public string Remarks { get; set; }
        public int Status { get; private set; }


        public CableDistribution() { }

        public CableDistribution(int? clientDetailsID, int? employeeID, int? cableForEmployeeID, int  cableStockID, int amountOfCableUsed, string purpose,
             int cableAssignFromWhere, int cableIndicatorStatus, string remarks)
        {
            ClientDetailsID = clientDetailsID;
            EmployeeID = employeeID;
            CableForEmployeeID = cableForEmployeeID;
            CableStockID = cableStockID;
            AmountOfCableUsed = amountOfCableUsed;
            Purpose = purpose;
            CableAssignFromWhere = cableAssignFromWhere;
            CableIndicatorStatus = cableIndicatorStatus;
            Remarks = remarks;

        }

        public void UpdateCableDistribution(int? clientDetailsID, int? employeeID, int? cableForEmployeeID, int cableStockID, int amountOfCableUsed, string purpose,
             int cableAssignFromWhere, int cableIndicatorStatus, string remarks)
        {
            ClientDetailsID = clientDetailsID;
            EmployeeID = employeeID;
            CableForEmployeeID = cableForEmployeeID;
            CableStockID = cableStockID;
            AmountOfCableUsed = amountOfCableUsed;
            Purpose = purpose;
            CableAssignFromWhere = cableAssignFromWhere;
            CableIndicatorStatus = cableIndicatorStatus;
            Remarks = remarks;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
