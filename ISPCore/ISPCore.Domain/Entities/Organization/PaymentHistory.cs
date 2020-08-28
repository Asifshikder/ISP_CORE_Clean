using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class PayementHistory : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public int? TransactionID { get; set; }
        public Transaction Transaction { get; set; }
        public int ClientDetailsID { get; set; }
        public ClientDetails ClientDetails { get; set; }
        public int? EmployeeID { get; set; }//this the employe who change the status
        public virtual Employee Employee { get; set; }
        public int? ResellerID { get; set; }//this the emreseller ploye who change the status
        public virtual Reseller Reseller { get; set; }
        public int CollectByID { get; set; }
        public DateTime PaymentDate { get; set; }
        public float PaidAmount { get; set; }
        public string ResetNo { get; set; }

        public int? AdvancePaymentID { get; set; }
        public AdvancePayment advancePayment { get; set; }
        public int? PaymentByID { get; set; }
        public PaymentBy PaymentBy { get; set; }

        public int? NormalPayment { get; set; }
        public int? DiscountPayment { get; set; }
        public string PaymentFromWhichPage { get; set; }
        public int BillAcceptBy { get; set; }
        public bool AcceptStatus { get; set; }

        public int Status { get; private set; }


        public PayementHistory() { }

        public PayementHistory(int? transactionID, int clientDetailsID,int? employeeID , int? resellerID ,int collectByID,
            float paidAmount,string resetNo , int? advancePaymentID,int? paymentByID,int? normalPayment,int? discountPayment,
            string paymentFromWhichPage ,int billAcceptBy, bool acceptStatus)
        {
            TransactionID = transactionID;
            ClientDetailsID= clientDetailsID;
            EmployeeID = employeeID;
            ResellerID = resellerID;
            CollectByID = collectByID;
            PaidAmount = paidAmount;
            ResetNo = resetNo;
            AdvancePaymentID = advancePaymentID;
            PaymentByID = paymentByID;
            NormalPayment = normalPayment;
            DiscountPayment = discountPayment;
            PaymentFromWhichPage = paymentFromWhichPage;
            BillAcceptBy = billAcceptBy;
            AcceptStatus = acceptStatus;
        }

        public void UpdatePayementHistory(int? transactionID, int clientDetailsID, int? employeeID, int? resellerID, int collectByID,
            float paidAmount, string resetNo, int? advancePaymentID, int? paymentByID, int? normalPayment, int? discountPayment,
            string paymentFromWhichPage, int billAcceptBy, bool acceptStatus)
        {
            TransactionID = transactionID;
            ClientDetailsID = clientDetailsID;
            EmployeeID = employeeID;
            ResellerID = resellerID;
            CollectByID = collectByID;
            PaidAmount = paidAmount;
            ResetNo = resetNo;
            AdvancePaymentID = advancePaymentID;
            PaymentByID = paymentByID;
            NormalPayment = normalPayment;
            DiscountPayment = discountPayment;
            PaymentFromWhichPage = paymentFromWhichPage;
            BillAcceptBy = billAcceptBy;
            AcceptStatus = acceptStatus;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
