using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.AccountListVsAmmountTransfer.Command
{
    public static class Commands
    {
        public static class AccountListVsAmmountTransfer
        {
            public class Create : IRequest<AccountListVsAmmountTransferCommandVM>
            {
                public int FromAccountID { get; set; }//from account
                public int ToAccountID { get; set; }//To account
                public DateTime TransferDate { get; set; }
                public int CurrencyID { get; set; }
                public decimal Amount { get; set; }
                public string Description { get; set; }
                public string Tags { get; set; }
                public int PaymentByID { get; set; }
                public string References { get; set; }
                public int BreakDownAccountListID { get; set; }// This is the ID for differentiate the In And Out
                public string TransferType { get; set; }
            }

            public class Update : IRequest<AccountListVsAmmountTransferCommandVM>
            {
                public int Id { get; set; }
                public int FromAccountID { get; set; }//from account
                public int ToAccountID { get; set; }//To account
                public DateTime TransferDate { get; set; }
                public int CurrencyID { get; set; }
                public decimal Amount { get; set; }
                public string Description { get; set; }
                public string Tags { get; set; }
                public int PaymentByID { get; set; }
                public string References { get; set; }
                public int BreakDownAccountListID { get; set; }// This is the ID for differentiate the In And Out
                public string TransferType { get; set; }
            }

            public class MarkAsDelete : IRequest<AccountListVsAmmountTransferCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
