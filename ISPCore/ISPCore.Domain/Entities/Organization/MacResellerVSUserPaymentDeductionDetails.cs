using ISPCore.Domain.Entities;
using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISPCore.Domain.Entities
{
    public class MacResellerVSUserPaymentDeductionDetails : BaseEntity, IHasId<int>, IAggregateRoot
    {
        //public int MacResellerVSUserPaymentDeductionDetailsID { get; set; }
        public int Id { get; private set; }
        public int ClientDetailsID { get; set; }
        public ClientDetails ClientDetails { get; set; }
        public int ResellerID { get; set; }
        public Reseller Reseller { get; set; }
        public int PaymentYear { get; set; }
        public int PaymentMonth { get; set; }
        public double PaymentAmount { get; set; }
        public DateTime PaymentTime { get; set; }
        public double PaymentTimeResellerBalance { get; set; }
        public int Status { get; private set; }

        public MacResellerVSUserPaymentDeductionDetails() { }

        public MacResellerVSUserPaymentDeductionDetails( int clientDetailsID ,int resellerID, int paymentYear, int paymentMonth,
             double paymentAmount,DateTime paymentTime ,double paymentTimeResellerBalance)
        {
            ClientDetailsID = clientDetailsID;
            ResellerID = resellerID;
            PaymentYear = paymentYear;
            PaymentMonth = paymentMonth;
            PaymentAmount = paymentAmount;
            PaymentTime = paymentTime;
            PaymentTimeResellerBalance = paymentTimeResellerBalance;

        }

        public void UpdateMacResellerVSUserPaymentDeductionDetails(int clientDetailsID, int resellerID, int paymentYear, int paymentMonth,
             double paymentAmount, DateTime paymentTime, double paymentTimeResellerBalance)
        {
            ClientDetailsID = clientDetailsID;
            ResellerID = resellerID;
            PaymentYear = paymentYear;
            PaymentMonth = paymentMonth;
            PaymentAmount = paymentAmount;
            PaymentTime = paymentTime;
            PaymentTimeResellerBalance = paymentTimeResellerBalance;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}