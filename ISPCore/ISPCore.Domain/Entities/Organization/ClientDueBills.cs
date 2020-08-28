using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class ClientDueBills : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public int ClientDetailsID { get; set; }
        public virtual ClientDetails ClientDetails { get; set; }
        public double DueAmount { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Status { get; private set; }


        public ClientDueBills() { }

        public ClientDueBills(int clientDetailsID,double dueAmount, int year, int month)
        {
            ClientDetailsID = clientDetailsID;
            DueAmount = dueAmount;
            Year = year;
            Month = month;
        }

        public void UpdateClientDueBills(int clientDetailsID, double dueAmount, int year, int month)
        {
            ClientDetailsID = clientDetailsID;
            DueAmount = dueAmount;
            Year = year;
            Month = month;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
