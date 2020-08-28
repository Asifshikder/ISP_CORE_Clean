using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.AdvancePayment.Queries.Models
{
    public class AdvancePaymentVM
    {
        public int Id { get; set; }
        public int ClientDetailsID { get; set; }
        public double AdvanceAmount { get; set; }
        public string Remarks { get; set; }
        public string CollectBy { get; set; }
    }
}
