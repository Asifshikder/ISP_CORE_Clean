using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.AccountList.Command
{
    public static class Commands
    {
        public static class AccountList
        {
            public class Create : IRequest<AccountListCommandVM>
            {

                public string AccountTitle { get; set; }
                public string Description { get; set; }
                public decimal? InitialBalance { get; set; }
                public int AccountNumber { get; set; }
                public string ContactPerson { get; set; }
                public string Phone { get; set; }
                public string BankURL { get; set; }
                public int OwnerID { get; set; }
            }

            public class Update : IRequest<AccountListCommandVM>
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

            public class MarkAsDelete : IRequest<AccountListCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
