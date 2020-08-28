using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class Transaction : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public int ClientDetailsID { get; set; }
        public virtual ClientDetails ClientDetails { get; set; }
        public int PaymentTransaction { get; set; }
        public int PaymentMonth { get; set; }
        public int? PackageID { get; set; }
        public virtual Package Package { get; set; }
        public int PaymentTypeID { get; set; }
        public PaymentType PaymentType { get; set; }
        public int? PaymentFrom { get; set; }
        public float? PaymentAmount { get; set; }//this Payment amount is for reseller user not for reseller payment amount
        public float? ResellerPaymentAmount { get; set; }//this Payment amount is for reseller payment amount not for reseller user
        public float? PackagePriceForResellerByAdminDuringCreateOrUpdate { get; set; }
        public float? PackagePriceForResellerUserByResellerDuringCreateOrUpdate { get; set; }
        public float? PaidAmount { get; set; }
        public float? DueAmount { get; set; }
        public int PaymentStatus { get; set; }
        public float? Discount { get; set; }
        public int? WhoGenerateTheBill { get; set; }
        public int? EmployeeID { get; set; }//ho paid the bail
        public virtual Employee Employee { get; set; }
        public int? BillCollectBy { get; set; }
        public string RemarksNo { get; set; }
        public string ResetNo { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int? LineStatusID { get; set; }// this is the id for latest line status change which will effet every hit except new connection mean paymenttype = new connection

        public virtual LineStatus LineStatus { get; set; }
        public DateTime? AmountCountDate { get; set; } 
        public int IsNewClient { get; set; }
        public int ChangePackageHowMuchTimes { get; set; }
        public int? ForWhichSignUpBills { get; set; } 
        public string PaymentFromWhichPage { get; set; }
        public int? ResellerID { get; set; }
        public virtual Reseller Reseller { get; set; }
        public DateTime? PaymentGenerateUptoWhichDate { get; set; }
        public string TransactionForWhichCycle { get; set; }
        public double PermanentDiscount { get; set; }
        public string AnotherMobileNo { get; set; }
        public int PaymentBy { get; set; }
        public int Status { get; private set; }


        public Transaction() { }

        public Transaction( int clientDetailsID,int paymentTransaction ,int paymentMonth ,int? packageID ,int paymentTypeID , int? paymentFrom ,
            float? paymentAmount, float? resellerPaymentAmount ,float? packagePriceForResellerByAdminDuringCreateOrUpdate ,float? packagePriceForResellerUserByResellerDuringCreateOrUpdate, float? paidAmount,
            float? dueAmount,int paymentStatus,float? discount,int? whoGenerateTheBill,int? employeeID,int? billCollectBy, string remarksNo , string resetNo, DateTime? paymentDate, int? lineStatusID, DateTime? amountCountDate ,
            int isNewClient,int changePackageHowMuchTimes,int? forWhichSignUpBills, string paymentFromWhichPage, int? resellerID,DateTime? paymentGenerateUptoWhichDate,
            string transactionForWhichCycle , double permanentDiscount, string anotherMobileNo , int paymentBy)
        {
            ClientDetailsID = clientDetailsID;
            PaymentTransaction = paymentTransaction;
            PaymentMonth = paymentMonth;
            PackageID = packageID;
            PaymentTypeID = paymentTypeID;
            PaymentFrom = paymentFrom;
            PaymentAmount = paymentAmount;
            ResellerPaymentAmount = resellerPaymentAmount;
            PackagePriceForResellerByAdminDuringCreateOrUpdate = packagePriceForResellerByAdminDuringCreateOrUpdate;
            PackagePriceForResellerUserByResellerDuringCreateOrUpdate = packagePriceForResellerUserByResellerDuringCreateOrUpdate;
            PaidAmount = paidAmount;
            DueAmount = dueAmount;
            PaymentStatus = paymentStatus;
            Discount = discount;
            WhoGenerateTheBill = whoGenerateTheBill;
            EmployeeID = employeeID;
            BillCollectBy = billCollectBy;
            RemarksNo = remarksNo;
            ResetNo = resetNo;
            PaymentDate = paymentDate;
            LineStatusID = lineStatusID;
            AmountCountDate = amountCountDate;
            IsNewClient = isNewClient;
            ChangePackageHowMuchTimes = changePackageHowMuchTimes;
            ForWhichSignUpBills = forWhichSignUpBills;
            PaymentFromWhichPage = paymentFromWhichPage;
            ResellerID = resellerID;
            PaymentGenerateUptoWhichDate = paymentGenerateUptoWhichDate;
            TransactionForWhichCycle = transactionForWhichCycle;
            PermanentDiscount = permanentDiscount;
            AnotherMobileNo = anotherMobileNo;
            PaymentBy = paymentBy;
        }

        public void UpdateTransaction(int clientDetailsID, int paymentTransaction, int paymentMonth, int? packageID, int paymentTypeID, int? paymentFrom,
            float? paymentAmount, float? resellerPaymentAmount, float? packagePriceForResellerByAdminDuringCreateOrUpdate, float? packagePriceForResellerUserByResellerDuringCreateOrUpdate, float? paidAmount,
            float? dueAmount, int paymentStatus, float? discount, int? whoGenerateTheBill, int? employeeID, int? billCollectBy, string remarksNo, string resetNo, DateTime? paymentDate, int? lineStatusID, DateTime? amountCountDate,
            int isNewClient, int changePackageHowMuchTimes, int? forWhichSignUpBills, string paymentFromWhichPage, int? resellerID, DateTime? paymentGenerateUptoWhichDate,
            string transactionForWhichCycle, double permanentDiscount, string anotherMobileNo, int paymentBy)
        {
            ClientDetailsID = clientDetailsID;
            PaymentTransaction = paymentTransaction;
            PaymentMonth = paymentMonth;
            PackageID = packageID;
            PaymentTypeID = paymentTypeID;
            PaymentFrom = paymentFrom;
            PaymentAmount = paymentAmount;
            ResellerPaymentAmount = resellerPaymentAmount;
            PackagePriceForResellerByAdminDuringCreateOrUpdate = packagePriceForResellerByAdminDuringCreateOrUpdate;
            PackagePriceForResellerUserByResellerDuringCreateOrUpdate = packagePriceForResellerUserByResellerDuringCreateOrUpdate;
            PaidAmount = paidAmount;
            DueAmount = dueAmount;
            PaymentStatus = paymentStatus;
            Discount = discount;
            WhoGenerateTheBill = whoGenerateTheBill;
            EmployeeID = employeeID;
            BillCollectBy = billCollectBy;
            RemarksNo = remarksNo;
            ResetNo = resetNo;
            PaymentDate = paymentDate;
            LineStatusID = lineStatusID;
            AmountCountDate = amountCountDate;
            IsNewClient = isNewClient;
            ChangePackageHowMuchTimes = changePackageHowMuchTimes;
            ForWhichSignUpBills = forWhichSignUpBills;
            PaymentFromWhichPage = paymentFromWhichPage;
            ResellerID = resellerID;
            PaymentGenerateUptoWhichDate = paymentGenerateUptoWhichDate;
            TransactionForWhichCycle = transactionForWhichCycle;
            PermanentDiscount = permanentDiscount;
            AnotherMobileNo = anotherMobileNo;
            PaymentBy = paymentBy;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
