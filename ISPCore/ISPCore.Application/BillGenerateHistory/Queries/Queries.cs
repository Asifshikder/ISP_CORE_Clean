using ISPCore.Application.BillGenerateHistory.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.BillGenerateHistory.Queries
{
    public static class Queries
    {
        public class GetBillGenerateHistoryList : IRequest<List<BillGenerateHistoryVM>>
        {
        }
        public class GetBillGenerateHistory : IRequest<BillGenerateHistoryVM>
        {
            public int Id { get; set; }
        }
    }
}
