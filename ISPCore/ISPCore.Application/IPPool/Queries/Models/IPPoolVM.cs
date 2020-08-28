using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.IPPool.Queries.Models
{
    public class IPPoolVM
    {
        public int Id { get; set; } 
        public string IPPoolName { get; set; }

        public string StartRange { get; set; }
        public string EndRange { get; set; }
    }
}
