using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.AccountList.Queries.Models
{
    public class AccountListVM
    {
        public int Id { get; set; }
        public string AccountTitle { get; set; }
        public string Description { get; set; }
        public decimal? InitialBalance { get; set; }
        public int AccountNumber { get; set; }
        public string ContactPerson { get; set; }
        public string Phone { get; set; }
        public string BankURL { get; set; }
        public int OwnerID { get; set; }
    }
}
