using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class ResellerPaymentDetailsHistory : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public int ResellerPaymentID { get; set; }
        public int ResellerID { get; set; }
        public virtual Reseller Reseller { get; set; }
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
        public PaymentBy PaymentBy { get; set; }
        public DateTime? PaymenReceivedDate { get; set; }

        public int Status { get; private set; }


        public ResellerPaymentDetailsHistory() { }

        public ResellerPaymentDetailsHistory(int resellerPaymentID , int resellerID,int resellerPaymentGivenTypeID ,int actionTypeID, double lastAmount,
            double paymentAmount, double deleteTimeResellerAmount,double paymentYear , double paymentMonth ,int paymentStatus , string paymentCheckOrAnySerial,
            int collectBy,int activeBy , int paymentByID, DateTime? paymenReceivedDate)
        {
            ResellerPaymentID = resellerPaymentID;
            ResellerID = resellerID;
            ResellerPaymentGivenTypeID = resellerPaymentGivenTypeID;
            ActionTypeID = actionTypeID;
            LastAmount = lastAmount;
            PaymentAmount = paymentAmount;
            DeleteTimeResellerAmount = deleteTimeResellerAmount;
            PaymentYear = paymentYear;
            PaymentMonth = paymentMonth;
            PaymentStatus = paymentStatus;
            PaymentCheckOrAnySerial = paymentCheckOrAnySerial;
            CollectBy = collectBy;
            ActiveBy = activeBy;
            PaymentByID = paymentByID;
            PaymenReceivedDate = paymenReceivedDate;
        }

        public void UpdateResellerPaymentDetailsHistory(int resellerPaymentID, int resellerID, int resellerPaymentGivenTypeID, int actionTypeID, double lastAmount,
            double paymentAmount, double deleteTimeResellerAmount, double paymentYear, double paymentMonth, int paymentStatus, string paymentCheckOrAnySerial,
            int collectBy, int activeBy, int paymentByID, DateTime? paymenReceivedDate)
        {
            ResellerPaymentID = resellerPaymentID;
            ResellerID = resellerID;
            ResellerPaymentGivenTypeID = resellerPaymentGivenTypeID;
            ActionTypeID = actionTypeID;
            LastAmount = lastAmount;
            PaymentAmount = paymentAmount;
            DeleteTimeResellerAmount = deleteTimeResellerAmount;
            PaymentYear = paymentYear;
            PaymentMonth = paymentMonth;
            PaymentStatus = paymentStatus;
            PaymentCheckOrAnySerial = paymentCheckOrAnySerial;
            CollectBy = collectBy;
            ActiveBy = activeBy;
            PaymentByID = paymentByID;
            PaymenReceivedDate = paymenReceivedDate;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
