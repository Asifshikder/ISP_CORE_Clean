using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Stock.Queries.Models
{
    public class StockVM
    {
        public int Id { get; set; }
        public int ItemID { get; set; }
        public int? Quantity { get; set; }
    }
}
