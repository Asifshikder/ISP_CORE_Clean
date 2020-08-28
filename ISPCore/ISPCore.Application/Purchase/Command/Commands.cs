using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Purchase.Command
{
    public static class Commands
    {
        public static class Purchase
        {
            public class Create : IRequest<PurchaseCommandVM>
            {
                public string Subject { get; set; }
                public int SupplierID { get; set; }
                public int PublishStatus { get; set; }
                public string InvoicePrefix { get; set; }
                public string InvoiceID { get; set; }
                public DateTime IssuedAt { get; set; }
                public string SupplierNoted { get; set; }
                public double SubTotal { get; set; }
                public int DiscountType { get; set; }
                public double DiscountPercentOrFixedAmount { get; set; }
                public double DiscountAmount { get; set; }
                public double Discount { get; set; }
                public double Tax { get; set; }
                public double Total { get; set; }
                public double PurchasePayment { get; set; }
                public int? ResellerID { get; set; }
                public int PurchaseStatus { get; set; }
            }

            public class Update : IRequest<PurchaseCommandVM>
            {
                public int Id { get; set; }
                public string Subject { get; set; }
                public int SupplierID { get; set; }
                public int PublishStatus { get; set; }
                public string InvoicePrefix { get; set; }
                public string InvoiceID { get; set; }
                public DateTime IssuedAt { get; set; }
                public string SupplierNoted { get; set; }
                public double SubTotal { get; set; }
                public int DiscountType { get; set; }
                public double DiscountPercentOrFixedAmount { get; set; }
                public double DiscountAmount { get; set; }
                public double Discount { get; set; }
                public double Tax { get; set; }
                public double Total { get; set; }
                public double PurchasePayment { get; set; }
                public int? ResellerID { get; set; }
                public int PurchaseStatus { get; set; }
            }

            public class MarkAsDelete : IRequest<PurchaseCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
