using ISPCore.Domain.Entities;
using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISPCore.Domain.Entities
{
    public class AccountListVsAmmountTransfer : BaseEntity, IHasId<int>, IAggregateRoot
    {
        //public int AccountListVsAmmountTransferID { get; set; }
        public int Id { get; private set; }
        public int FromAccountID { get; set; }//from account
        public int ToAccountID { get; set; }//To account
        public DateTime TransferDate { get; set; }
        public int CurrencyID { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }
        public int PaymentByID { get; set; }
        public virtual PaymentBy PaymentBy { get; set; }
        public string References { get; set; }
        public int BreakDownAccountListID { get; set; }// This is the ID for differentiate the In And Out
        public string TransferType { get; set; }



        public int Status { get; private set; }

        public AccountListVsAmmountTransfer() { }

        public AccountListVsAmmountTransfer(int fromAccountID, int toAccountID, DateTime transferDate, int currencyID, decimal amount, string description,
            string tags, int paymentByID, string references, int breakDownAccountListId, string transferType  )
        {
            FromAccountID = fromAccountID;
            ToAccountID = toAccountID;
            TransferDate = transferDate;
            CurrencyID = currencyID;
            Amount = amount;
            Description = description;
            Tags = tags;
            PaymentByID = paymentByID;
            References = references;
            BreakDownAccountListID = breakDownAccountListId;
            TransferType = transferType;
        }

        public void UpdateAccountListVsAmmountTransfer(int fromAccountID, int toAccountID, DateTime transferDate, int currencyID, decimal amount, string description,
            string tags, int paymentByID, string references, int breakDownAccountListId, string transferType )
        {
            FromAccountID = fromAccountID;
            ToAccountID = toAccountID;
            TransferDate = transferDate;
            CurrencyID = currencyID;
            Amount = amount;
            Description = description;
            Tags = tags;
            PaymentByID = paymentByID;
            References = references;
            BreakDownAccountListID = breakDownAccountListId;
            TransferType = transferType; 
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}