using ISPCore.Application.PayementHistory.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.PayementHistory.Queries
{
    public static class Queries
    {
        public class GetPayementHistoryList : IRequest<List<PayementHistoryVM>>
        {
        }
        public class GetPayementHistory : IRequest<PayementHistoryVM>
        {
            public int Id { get; set; }
        }
    }
}
