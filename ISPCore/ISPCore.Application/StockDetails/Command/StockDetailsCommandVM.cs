using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.StockDetails.Command
{
    public class StockDetailsCommandVM
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public string Message { get; set; }
    }
}
