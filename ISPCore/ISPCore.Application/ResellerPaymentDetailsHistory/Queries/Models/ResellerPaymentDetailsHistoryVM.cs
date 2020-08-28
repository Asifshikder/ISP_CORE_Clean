using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ResellerPaymentDetailsHistory.Queries.Models
{
    public class ResellerPaymentDetailsHistoryVM
    {
        public int Id { get; set; }
        public int ResellerPaymentID { get; set; }
        public int ResellerID { get; set; }
        public int ResellerPaymentGivenTypeID { get; set; } //cash or check or some other.
        public int ActionTypeID { get; set; } //cash  purchase or cash purchase return
        public double LastAmount { get; set; }
        public double PaymentAmount { get; set; }
        public double DeleteTimeResellerAmount { get; set; }
        public double PaymentYear { get; set; }
        public double PaymentMonth { get; set; }
        public int PaymentStatus { get; set; }
        public string PaymentCheckOrAnySerial { get; set; }
        public int CollectBy { get; set; }
        public int ActiveBy { get; set; }
        public int PaymentByID { get; set; }
        public DateTime? PaymenReceivedDate { get; set; }
    }
}
