using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Stock.Command
{
    public class StockCommandVM
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public string Message { get; set; }
    }
}
