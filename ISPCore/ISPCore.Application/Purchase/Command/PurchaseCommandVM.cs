using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Purchase.Command
{
    public class PurchaseCommandVM
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public string Message { get; set; }
    }
}
