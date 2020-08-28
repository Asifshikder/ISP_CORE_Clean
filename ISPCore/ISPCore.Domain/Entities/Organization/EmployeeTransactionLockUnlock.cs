using ISPCore.Domain.Entities;
using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISPCore.Domain.Entities
{
    public class EmployeeTransactionLockUnlock : BaseEntity, IHasId<int>, IAggregateRoot
    {
        //public int EmployeeTransactionLockUnlockID { get; set; }
        public int Id { get; private set; }
        public int TransactionID { get; set; }
        public Transaction Transaction { get; set; }
        public int? PackageID { get; set; }
        public virtual Package Package { get; set; }
        public double Amount { get; set; } //those days bill  user for resller or admin
        public double AmountForReseller { get; set; }
        public DateTime FromDate { get; set; } 
        public DateTime ToDate { get; set; }  
        public DateTime? LockOrUnlockDate { get; set; } 
        public int? EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }
        public int? ResellerID { get; set; }
        public virtual Reseller Reseller { get; set; }

        public int Status { get; private set; }

        public EmployeeTransactionLockUnlock() { }

        public EmployeeTransactionLockUnlock(int transactionID ,int? packageID,double amount,double amountForReseller,DateTime fromDate
            , DateTime toDate , DateTime? lockOrUnlockDate ,int? employeeID ,int? resellerID )
        {
            TransactionID = transactionID;
            PackageID = packageID;
            Amount = amount;
            AmountForReseller = amountForReseller;
            FromDate = fromDate;
            ToDate = toDate;
            LockOrUnlockDate = lockOrUnlockDate;
            EmployeeID = employeeID;
            ResellerID = resellerID;
        }

        public void UpdateEmployeeTransactionLockUnlock(int transactionID, int? packageID, double amount, double amountForReseller, DateTime fromDate
            , DateTime toDate, DateTime? lockOrUnlockDate, int? employeeID, int? resellerID)
        {
            TransactionID = transactionID;
            PackageID = packageID;
            Amount = amount;
            AmountForReseller = amountForReseller;
            FromDate = fromDate;
            ToDate = toDate;
            LockOrUnlockDate = lockOrUnlockDate;
            EmployeeID = employeeID;
            ResellerID = resellerID;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}