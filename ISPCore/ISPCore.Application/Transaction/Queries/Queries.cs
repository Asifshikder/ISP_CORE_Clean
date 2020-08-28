using ISPCore.Application.Transaction.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Transaction.Queries
{
    public static class Queries
    {
        public class GetTransactionList : IRequest<List<TransactionVM>>
        {
        }
        public class GetTransaction : IRequest<TransactionVM>
        {
            public int Id { get; set; }
        }
    }
}
