using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class ClientLineStatus : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }

        public int CLSClientDetailsID { get; set; }

        public virtual ClientDetails ClientDetails { get; set; }
        public int? PackageID { get; set; }
        public virtual Package Package { get; set; }
        public int LineStatusID { get; set; }
        public virtual LineStatus LineStatus { get; set; }
        public int? LineStatusFromWhichMonth { get; set; }
        public string StatusChangeReason { get; set; }
        public DateTime? LineStatusChangeDate { get; set; }
        public int? EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }
        public int? ResellerID { get; set; }
        public virtual Reseller Reseller { get; set; }
        public int? MikrotikID { get; set; }
        public virtual Mikrotik Mikrotik { get; set; }
        public bool IsLineStatusApplied { get; set; }
        public DateTime? LineStatusWillActiveInThisDate { get; set; }
        public bool StatusFromNow { get; set; }


        public int StatusThisMonth { get; set; }
        public int StatusNextMonth { get; set; }

        public int PackageThisMonth { get; set; }
        public int PackageNextMonth { get; set; }

        public int Status { get; private set; }


        public ClientLineStatus() { }

        public ClientLineStatus(  int clientDetailsID ,int? packageID,int lineStatusID ,int? lineStatusFromWhichMonth , string statusChangeReason, DateTime? lineStatusChangeDate,
            int? employeeID,int? resellerID , int? mikrotikID, bool isLineStatusApplied, DateTime? lineStatusWillActiveInThisDate, bool statusFromNow,
            int statusThisMonth,int statusNextMonth ,int packageThisMonth, int packageNextMonth)
        {
            CLSClientDetailsID = clientDetailsID;
            PackageID = packageID;
            LineStatusID = lineStatusID;
            LineStatusFromWhichMonth = lineStatusFromWhichMonth;
            StatusChangeReason = statusChangeReason;
            LineStatusChangeDate = lineStatusChangeDate;
            EmployeeID = employeeID;
            ResellerID = resellerID;
            MikrotikID = mikrotikID;
            IsLineStatusApplied = isLineStatusApplied;
            LineStatusWillActiveInThisDate = lineStatusWillActiveInThisDate;
            StatusFromNow = statusFromNow;
            StatusThisMonth = statusThisMonth;
            StatusNextMonth = statusNextMonth;
            PackageThisMonth = packageThisMonth;
            PackageNextMonth = packageNextMonth;
        }

        public void UpdateClientLineStatus(int clientDetailsID, int? packageID, int lineStatusID, int? lineStatusFromWhichMonth, string statusChangeReason, DateTime? lineStatusChangeDate,
            int? employeeID, int? resellerID, int? mikrotikID, bool isLineStatusApplied, DateTime? lineStatusWillActiveInThisDate, bool statusFromNow,
            int statusThisMonth, int statusNextMonth, int packageThisMonth, int packageNextMonth)
        {
            CLSClientDetailsID = clientDetailsID;
            PackageID = packageID;
            LineStatusID = lineStatusID;
            LineStatusFromWhichMonth = lineStatusFromWhichMonth;
            StatusChangeReason = statusChangeReason;
            LineStatusChangeDate = lineStatusChangeDate;
            EmployeeID = employeeID;
            ResellerID = resellerID;
            MikrotikID = mikrotikID;
            IsLineStatusApplied = isLineStatusApplied;
            LineStatusWillActiveInThisDate = lineStatusWillActiveInThisDate;
            StatusFromNow = statusFromNow;
            StatusThisMonth = statusThisMonth;
            StatusNextMonth = statusNextMonth;
            PackageThisMonth = packageThisMonth;
            PackageNextMonth = packageNextMonth;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
