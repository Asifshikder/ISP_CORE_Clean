using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ResellerPaymentDetailsHistory.Command
{
    public class ResellerPaymentDetailsHistoryCommandVM
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public string Message { get; set; }
    }
}
