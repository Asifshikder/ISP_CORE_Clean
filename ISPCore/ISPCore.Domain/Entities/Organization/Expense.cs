using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class Expense : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public string Descriptions { get; set; }
        public byte[] DescriptionFileByte { get; set; }
        public string DescriptionFilePath { get; set; }
        public int HeadID { get; set; }
        public virtual Head Head { get; set; }
        public double Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public int CompanyID { get; set; }
        public virtual Company Company { get; set; }
        public int AccountListID { get; set; }
        public virtual AccountList AccountList { get; set; }
        public int PayerID { get; set; }
        public virtual CompanyVsPayer CompanyVSPayer { get; set; }
        public int PaymentByID { get; set; }
        public virtual PaymentBy PaymentBy { get; set; }
        public int ExpenseStatus { get; set; }
        public string References { get; set; }
        public int ResellerID { get; set; }
        public Reseller Reseller { get; set; }
        public int Status { get; private set; }


        public Expense() { }

        public Expense(string descriptions , byte[] descriptionFileByte,string descriptionFilePath , int headID , double amount ,DateTime paymentDate,
            int companyID,int accountListID, int payerID,int paymentByID, int expenseStatus ,string references, int resellerID )
        {
            Descriptions = descriptions;
            DescriptionFileByte = descriptionFileByte;
            DescriptionFilePath = descriptionFilePath;
            HeadID = headID;
            Amount = amount;
            PaymentDate = paymentDate;
            CompanyID = companyID;
            AccountListID = accountListID;
            PayerID = payerID;
            PaymentByID = paymentByID;
            ExpenseStatus = expenseStatus;
            References = references;
            ResellerID = resellerID;
        }

        public void UpdateExpense(string descriptions, byte[] descriptionFileByte, string descriptionFilePath, int headID, double amount, DateTime paymentDate,
            int companyID, int accountListID, int payerID, int paymentByID, int expenseStatus, string references, int resellerID)
        {
            Descriptions = descriptions;
            DescriptionFileByte = descriptionFileByte;
            DescriptionFilePath = descriptionFilePath;
            HeadID = headID;
            Amount = amount;
            PaymentDate = paymentDate;
            CompanyID = companyID;
            AccountListID = accountListID;
            PayerID = payerID;
            PaymentByID = paymentByID;
            ExpenseStatus = expenseStatus;
            References = references;
            ResellerID = resellerID;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
