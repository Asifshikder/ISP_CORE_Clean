using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class AccountingHistory : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public int AccountListID { get; set; }
        public int PurchaseID { get; set; }
        public int SalesID { get; set; }
        public int DepositID { get; set; }
        public int ExpenseID { get; set; }
        public int ActionTypeID { get; set; }//what type of action it is.
        public int DRCRTypeID { get; set; }//is it DR Or CR
        public double Amount { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public int Status { get; private set; }

        public AccountingHistory() { }

        public AccountingHistory(int accountListID, int purchaseID, int salesID, int depositID, int expenseID, int actionTypeID, int dRCRTypeID,double amount,int year,int month,int day,DateTime date, string description)
        {
            AccountListID = accountListID;
            PurchaseID = purchaseID;
            SalesID = salesID;
            DepositID = depositID;
            ExpenseID = expenseID;
            ActionTypeID = actionTypeID;
            DRCRTypeID = dRCRTypeID;
            Amount = amount;
            Year = year;
            Month = month;
            Day = day;
            Description = description;
        }

        public void UpdateAccountingHistory(int accountListID, int purchaseID, int salesID, int depositID, int expenseID, int actionTypeID, int dRCRTypeID, double amount, int year, int month, int day, DateTime date, string description)
        {
            AccountListID = accountListID;
            PurchaseID = purchaseID;
            SalesID = salesID;
            DepositID = depositID;
            ExpenseID = expenseID;
            ActionTypeID = actionTypeID;
            DRCRTypeID = dRCRTypeID;
            Amount = amount;
            Year = year;
            Month = month;
            Day = day;
            Description = description;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
