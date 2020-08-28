using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Transaction.Queries.Models
{
    public class TransactionVM
    {
        public int Id { get; set; }
        public int ClientDetailsID { get; set; }
        public int PaymentTransaction { get; set; }
        public int PaymentMonth { get; set; }
        public int? PackageID { get; set; }
        public int PaymentTypeID { get; set; }
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
        public int? BillCollectBy { get; set; }
        public string RemarksNo { get; set; }
        public string ResetNo { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int? LineStatusID { get; set; }
        public DateTime? AmountCountDate { get; set; }
        public int IsNewClient { get; set; }
        public int ChangePackageHowMuchTimes { get; set; }
        public int? ForWhichSignUpBills { get; set; }
        public string PaymentFromWhichPage { get; set; }
        public int? ResellerID { get; set; }
        public DateTime? PaymentGenerateUptoWhichDate { get; set; }
        public string TransactionForWhichCycle { get; set; }
        public double PermanentDiscount { get; set; }
        public string AnotherMobileNo { get; set; }
        public int PaymentBy { get; set; }
    }
}
