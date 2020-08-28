using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class Complain : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }

        public int ClientDetailsID { get; set; }

        public virtual ClientDetails ClientDetails { get; set; }

        public int TokenNo { get; set; }

        public string MonthlySerialNo { get; set; }

        public string ComplainDetails { get; set; }

        public int? EmployeeID { get; set; }//Assign to

        public virtual Employee Employee { get; set; }

        public int? ResellerID { get; set; } 

        public virtual Reseller Reseller { get; set; }

        public int LineStatusID { get; set; }// for Status

        public virtual LineStatus LineStatus { get; set; }

        public int ComplainTypeID { get; set; }

        public virtual ComplainType ComplainType { get; set; }

        public string WhichOrWhere { get; set; }

        public int ComplainOpenBy { get; set; }

        public DateTime ComplainTime { get; set; }

        public bool OnRequest { get; set; }

        public int Status { get; private set; }


        public Complain() { }

        public Complain(  int clientDetailsID,int tokenNo, string monthlySerialNo , string complainDetails, int? employeeID,
            int? resellerID , int lineStatusID ,int complainTypeID , string whichOrWhere, int complainOpenBy,DateTime complainTime,bool onRequest)
        {
            ClientDetailsID = clientDetailsID;
            TokenNo = tokenNo;
            MonthlySerialNo = monthlySerialNo;
            ComplainDetails = complainDetails;
            EmployeeID = employeeID;
            ResellerID = resellerID;
            LineStatusID = lineStatusID;
            ComplainTypeID = complainTypeID;
            WhichOrWhere = whichOrWhere;
            ComplainOpenBy = complainOpenBy;
            ComplainTime = complainTime;
            OnRequest = onRequest;
        }

        public void UpdateComplain(int clientDetailsID, int tokenNo, string monthlySerialNo, string complainDetails, int? employeeID,
            int? resellerID, int lineStatusID, int complainTypeID, string whichOrWhere, int complainOpenBy, DateTime complainTime, bool onRequest)
        {
            ClientDetailsID = clientDetailsID;
            TokenNo = tokenNo;
            MonthlySerialNo = monthlySerialNo;
            ComplainDetails = complainDetails;
            EmployeeID = employeeID;
            ResellerID = resellerID;
            LineStatusID = lineStatusID;
            ComplainTypeID = complainTypeID;
            WhichOrWhere = whichOrWhere;
            ComplainOpenBy = complainOpenBy;
            ComplainTime = complainTime;
            OnRequest = onRequest;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
