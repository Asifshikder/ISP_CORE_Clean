using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.MacResellerVSUserPaymentDeductionDetails.Queries.Models
{
    public class MacResellerVSUserPaymentDeductionDetailsVM
    {
        public int Id { get; set; }
        public int ClientDetailsID { get; set; }
        public int ResellerID { get; set; }
        public int PaymentYear { get; set; }
        public int PaymentMonth { get; set; }
        public double PaymentAmount { get; set; }
        public DateTime PaymentTime { get; set; }
        public double PaymentTimeResellerBalance { get; set; }
    }
}
