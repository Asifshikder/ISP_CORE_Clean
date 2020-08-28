using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.PurchaseDetails.Queries.Models
{
    public class PurchaseDetailsVM
    {
        public int Id { get; set; }
        public int PurchaseID { get; set; }
        public int ItemID { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public double Tax { get; set; }
        public bool HasWarrenty { get; set; }
        public DateTime? WarrentyStart { get; set; }
        public DateTime? WarrentyEnd { get; set; }
        public string Serial { get; set; }
    }
}
