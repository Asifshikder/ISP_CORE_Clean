using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class PurchasePaymentHistory : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public int PurchaseID { get; set; }
        public Purchase purchase { get; set; }
        public int AccountListID { get; set; }
        public AccountList AccountList { get; set; }
        public int PaymentByID { get; set; }
        public DateTime PurchasePaymentDate { get; set; }
        public string CheckNo { get; set; }
        public string CheckName { get; set; }
        public string CheckPath { get; set; }
        public byte[] CheckImageBytes { get; set; }
        public string Description { get; set; }
        public double PaymentAmount { get; set; }
        public int PaymentPaidBy { get; set; }

        public int Status { get; private set; }

        public PurchasePaymentHistory() { }

        public PurchasePaymentHistory(int purchaseID , int accountListID ,int paymentByID,DateTime purchasePaymentDate ,string checkNo,
            string checkName, string checkPath,byte[] checkImageBytes,string description,double paymentAmount,int paymentPaidBy )
        {
            PurchaseID = purchaseID;
            AccountListID = accountListID;
            PaymentByID = paymentByID;
            PurchasePaymentDate = purchasePaymentDate;
            CheckNo = checkNo;
            CheckName = checkName;
            CheckPath = checkPath;
            CheckImageBytes = checkImageBytes;
            Description = description;
            PaymentAmount = paymentAmount;
            PaymentPaidBy = paymentPaidBy;

        }

        public void UpdatePurchasePaymentHistory(int purchaseID, int accountListID, int paymentByID, DateTime purchasePaymentDate, string checkNo,
            string checkName, string checkPath, byte[] checkImageBytes, string description, double paymentAmount, int paymentPaidBy)
        {
            PurchaseID = purchaseID;
            AccountListID = accountListID;
            PaymentByID = paymentByID;
            PurchasePaymentDate = purchasePaymentDate;
            CheckNo = checkNo;
            CheckName = checkName;
            CheckPath = checkPath;
            CheckImageBytes = checkImageBytes;
            Description = description;
            PaymentAmount = paymentAmount;
            PaymentPaidBy = paymentPaidBy;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
