using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class PaymentType : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public string PaymentTypeName { get; private set; }

        public int Status { get; private set; }


        public PaymentType() { }

        public PaymentType(string paymentTypeName)
        {
            PaymentTypeName = paymentTypeName;
        }

        public void UpdatePaymentType(string paymentTypeName)
        {
            PaymentTypeName = paymentTypeName;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
