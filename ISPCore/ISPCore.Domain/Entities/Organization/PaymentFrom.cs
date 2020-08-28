using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class PaymentFrom : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public string PaymentFromName { get; private set; }

        public int Status { get; private set; }


        public PaymentFrom() { }

        public PaymentFrom(string paymentFromName)
        {
            PaymentFromName = paymentFromName;
        }

        public void UpdatePaymentFrom(string paymentFromName)
        {
            PaymentFromName = paymentFromName;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
