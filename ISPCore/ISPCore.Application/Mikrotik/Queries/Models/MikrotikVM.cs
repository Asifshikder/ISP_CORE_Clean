using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Mikrotik.Queries.Models
{
    public class MikrotikVM
    {
        public int Id { get; set; } 
        public string MikrotikName { get; set; }
        public string RealIP { get; set; }
        public string MikUserName { get; set; }
        public string MikPassword { get; set; }
        public int APIPort { get; set; }
        public int WebPort { get; set; }
    }
}
