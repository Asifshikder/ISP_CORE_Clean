using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.EmployeeTransactionLockUnlock.Command
{
    public static class Commands
    {
        public static class EmployeeTransactionLockUnlock
        {
            public class Create : IRequest<EmployeeTransactionLockUnlockCommandVM>
            {
                public int TransactionID { get; set; }
                public int? PackageID { get; set; }
                public double Amount { get; set; } //those days bill  user for resller or admin
                public double AmountForReseller { get; set; }
                public DateTime FromDate { get; set; }
                public DateTime ToDate { get; set; }
                public DateTime? LockOrUnlockDate { get; set; }
                public int? EmployeeID { get; set; }
                public int? ResellerID { get; set; }
            }

            public class Update : IRequest<EmployeeTransactionLockUnlockCommandVM>
            {
                public int Id { get; set; }
                public int TransactionID { get; set; }
                public int? PackageID { get; set; }
                public double Amount { get; set; } //those days bill  user for resller or admin
                public double AmountForReseller { get; set; }
                public DateTime FromDate { get; set; }
                public DateTime ToDate { get; set; }
                public DateTime? LockOrUnlockDate { get; set; }
                public int? EmployeeID { get; set; }
                public int? ResellerID { get; set; }
            }

            public class MarkAsDelete : IRequest<EmployeeTransactionLockUnlockCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
