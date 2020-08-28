using ISPCore.Application.Distribution_Transaction.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Distribution_Transaction.Queries
{
    public static class Queries
    {
        public class GetDistribution_TransactionList : IRequest<List<Distribution_TransactionVM>>
        {
        }
        public class GetDistribution_Transaction : IRequest<Distribution_TransactionVM>
        {
            public int Id { get; set; }
        }
    }
}
