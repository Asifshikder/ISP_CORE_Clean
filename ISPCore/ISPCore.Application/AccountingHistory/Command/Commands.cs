using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.AccountingHistory.Command
{
    public static class Commands
    {
        public static class AccountingHistory
        {
            public class Create : IRequest<AccountingHistoryCommandVM>
            {
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
            }

            public class Update : IRequest<AccountingHistoryCommandVM>
            {
                public int Id { get; set; }
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
            }

            public class MarkAsDelete : IRequest<AccountingHistoryCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
