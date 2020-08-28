using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class AccountList : BaseEntity, IHasId<int>, IAggregateRoot
    {
        //public int ControllerID { get; set; }
        public int Id { get; private set; }
        public string AccountTitle { get; set; }
        public string Description { get; set; }
        public decimal? InitialBalance { get; set; }
        public int AccountNumber { get; set; }
        public string ContactPerson { get; set; }
        public string Phone { get; set; }
        public string BankURL { get; set; }
        public int OwnerID { get; set; }
        public virtual AccountOwner AccountOwner { get; set; }

        public int Status { get; private set; }

        public AccountList() { }

        public AccountList(string accountTitle, string description, decimal? initialBalance, int accountNumber, string contactPerson,string phone,string bankURL,int ownerID)
        {
            AccountTitle = accountTitle;
            Description = description;
            InitialBalance = initialBalance;
            AccountNumber = accountNumber;
            ContactPerson = contactPerson;
            Phone = phone;
            BankURL = bankURL;
            OwnerID = ownerID;
        }

        public void UpdateAccountList(string accountTitle, string description, decimal? initialBalance, int accountNumber, string contactPerson, string phone, string bankURL, int ownerID)
        {
            AccountTitle = accountTitle;
            Description = description;
            InitialBalance = initialBalance;
            AccountNumber = accountNumber;
            ContactPerson = contactPerson;
            Phone = phone;
            BankURL = bankURL;
            OwnerID = ownerID;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
