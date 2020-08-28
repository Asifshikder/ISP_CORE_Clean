using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class Purchase : BaseEntity, IHasId<int>, IAggregateRoot
    {
        //public int PurchaseID { get; set; }
        public int Id { get; private set; }
        public string Subject { get; set; }
        public int SupplierID { get; set; }
        public Supplier Supplier { get; set; }
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
        public Reseller Reseller { get; set; }
        public int PurchaseStatus { get; set; }

        public int Status { get; private set; }
        public Purchase() { }

        public Purchase(string subject,int supplierID, int publishStatus, string invoicePrefix, string invoiceID, DateTime issuedAt, string supplierNoted,
            double subTotal, int discountType, double discountPercentOrFixedAmount, double discountAmount, double discount,double tax, double total,
            double purchasePayment, int? resellerID, int purchaseStatus )
        {
            Subject = subject;
            SupplierID = supplierID;
            PublishStatus = publishStatus;
            InvoicePrefix = invoicePrefix;
            InvoiceID = invoiceID;
            IssuedAt = issuedAt;
            SupplierNoted = supplierNoted;
            SubTotal = subTotal;
            DiscountType = discountType;
            DiscountPercentOrFixedAmount = discountPercentOrFixedAmount;
            DiscountAmount = discountAmount;
            Discount = discount;
            Tax = tax;
            PurchasePayment = purchasePayment;
            ResellerID = resellerID;
            PurchaseStatus = purchaseStatus;
        }

        public void UpdatePurchase(string subject, int supplierID, int publishStatus, string invoicePrefix, string invoiceID, DateTime issuedAt, string supplierNoted,
            double subTotal, int discountType, double discountPercentOrFixedAmount, double discountAmount, double discount, double tax, double total,
            double purchasePayment, int? resellerID, int purchaseStatus)
        {
            Subject = subject;
            SupplierID = supplierID;
            PublishStatus = publishStatus;
            InvoicePrefix = invoicePrefix;
            InvoiceID = invoiceID;
            IssuedAt = issuedAt;
            SupplierNoted = supplierNoted;
            SubTotal = subTotal;
            DiscountType = discountType;
            DiscountPercentOrFixedAmount = discountPercentOrFixedAmount;
            DiscountAmount = discountAmount;
            Discount = discount;
            Tax = tax;
            PurchasePayment = purchasePayment;
            ResellerID = resellerID;
            PurchaseStatus = purchaseStatus;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
