using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Item.Queries.Models
{
    public class ItemVM
    {
        public int Id { get; set; } 
        public string ItemName { get; set; }
        public int? ItemFor { get; set; }
        public string ItemCode { get; set; }
    }
}
