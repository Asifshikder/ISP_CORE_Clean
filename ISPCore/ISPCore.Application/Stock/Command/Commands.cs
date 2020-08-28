using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Stock.Command
{
    public static class Commands
    {
        public static class Stock
        {
            public class Create : IRequest<StockCommandVM>
            {
                public int ItemID { get; set; }
                public int? Quantity { get; set; }
            }

            public class Update : IRequest<StockCommandVM>
            {
                public int Id { get; set; }
                public int ItemID { get; set; }
                public int? Quantity { get; set; }
            }

            public class MarkAsDelete : IRequest<StockCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
