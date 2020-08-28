using ISPCore.Domain.Entities;
using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISPCore.Domain.Entities
{
    public class AdvancePayment : BaseEntity, IHasId<int>, IAggregateRoot
    {
        //public int AdvancePaymentID { get; set; }
        public int Id { get; private set; }
        public int ClientDetailsID { get; set; }
        public virtual ClientDetails ClientDetils { get; set; }
        public double AdvanceAmount { get; set; }
        public string Remarks { get; set; }
        public string CollectBy { get; set; }

        public int Status { get; private set; }

        public AdvancePayment() { }

        public AdvancePayment(int clientDetailsID,double advanceAmount,string remarks, string collectBy )
        {
            ClientDetailsID = clientDetailsID;
            AdvanceAmount = advanceAmount;
            Remarks = remarks;
            CollectBy = collectBy;
        }

        public void UpdateAdvancePayment(int clientDetailsID, double advanceAmount, string remarks, string collectBy)
        {
            ClientDetailsID = clientDetailsID;
            AdvanceAmount = advanceAmount;
            Remarks = remarks;
            CollectBy = collectBy;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}