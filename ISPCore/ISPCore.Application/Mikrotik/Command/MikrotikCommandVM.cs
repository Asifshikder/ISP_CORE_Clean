using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Mikrotik.Command
{
    public class MikrotikCommandVM
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public string Message { get; set; }
    }
}
