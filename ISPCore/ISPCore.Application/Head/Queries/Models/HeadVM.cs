using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Head.Queries.Models
{
    public class HeadVM
    {
        public int Id { get; set; } 
        public string HeadName { get; set; }
        public int HeadTypeID { get; set; }
        public int? ResellerID { get; set; }
    }
}
