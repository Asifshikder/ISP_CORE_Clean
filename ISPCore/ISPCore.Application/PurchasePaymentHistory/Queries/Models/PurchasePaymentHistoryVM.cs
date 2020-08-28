using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.PurchasePaymentHistory.Queries.Models
{
    public class PurchasePaymentHistoryVM
    {
        public int Id { get; set; }
        public int PurchaseID { get; set; }
        public int AccountListID { get; set; }
        public int PaymentByID { get; set; }
        public DateTime PurchasePaymentDate { get; set; }
        public string CheckNo { get; set; }
        public string CheckName { get; set; }
        public string CheckPath { get; set; }
        public byte[] CheckImageBytes { get; set; }
        public string Description { get; set; }
        public double PaymentAmount { get; set; }
        public int PaymentPaidBy { get; set; }
    }
}
