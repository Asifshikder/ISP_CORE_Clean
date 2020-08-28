using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
   public class PaymentBy : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public string PaymentByName { get; private set; }

        public int Status { get; private set; }


        public PaymentBy() { }

        public PaymentBy(string paymentByName)
        {
            PaymentByName = paymentByName;
        }

        public void UpdatePaymentBy(string paymentByName)
        {
            PaymentByName = paymentByName;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
