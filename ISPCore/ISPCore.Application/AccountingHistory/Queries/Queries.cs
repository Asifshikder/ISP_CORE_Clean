using ISPCore.Application.AccountingHistory.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.AccountingHistory.Queries
{
    public static class Queries
    {
        public class GetAccountingHistoryList : IRequest<List<AccountingHistoryVM>>
        {
        }
        public class GetAccountingHistory : IRequest<AccountingHistoryVM>
        {
            public int Id { get; set; }
        }
    }
}
