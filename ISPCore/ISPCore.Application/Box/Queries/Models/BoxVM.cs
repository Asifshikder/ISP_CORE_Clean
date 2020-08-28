using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Box.Queries.Models
{
    public class BoxVM
    {
        public int Id { get; set; } 
        public string BoxName { get; set; }
        public int? ResellerID { get; set; }
        public string BoxLocation { get; set; }
    }
}
