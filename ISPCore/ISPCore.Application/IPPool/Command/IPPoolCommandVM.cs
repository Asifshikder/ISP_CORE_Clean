using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.IPPool.Command
{
    public class IPPoolCommandVM
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public string Message { get; set; }
    }
}
