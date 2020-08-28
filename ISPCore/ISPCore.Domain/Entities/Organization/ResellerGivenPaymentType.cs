using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class GivenPaymentType : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public string GivenPaymentTypeName { get; set; }

        public int Status { get; private set; }

        public GivenPaymentType() { }

        public GivenPaymentType(string givenPaymentTypeName)
        {
            GivenPaymentTypeName = givenPaymentTypeName;

        }

        public void UpdateGivenPaymentType(string givenPaymentTypeName)
        {
            GivenPaymentTypeName = givenPaymentTypeName;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
