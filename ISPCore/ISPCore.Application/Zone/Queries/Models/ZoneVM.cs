using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Zone.Queries.Models
{
    public class ZoneVM
    {
        public int Id { get; set; } 
        public string ZoneName { get; set; }
        public int? ResellerID { get; set; }
    }
}
