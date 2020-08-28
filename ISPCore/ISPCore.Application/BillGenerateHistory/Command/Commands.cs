using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.BillGenerateHistory.Command
{
    public static class Commands
    {
        public static class BillGenerateHistory
        {
            public class Create : IRequest<BillGenerateHistoryCommandVM>
            {

                public string Year { get; set; }
                public string Month { get; set; }
            }

            public class Update : IRequest<BillGenerateHistoryCommandVM>
            {
                public int Id { get; set; }
                public string Year { get; set; }
                public string Month { get; set; }
            }

            public class MarkAsDelete : IRequest<BillGenerateHistoryCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
