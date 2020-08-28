using ISPCore.Domain.Entities;
using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISPCore.Domain.Entities
{
    public class BillGenerateHistory : BaseEntity, IHasId<int>, IAggregateRoot
    {
        //public int BillGenerateHistoryID { get; set; }
        public int Id { get; private set; }
        public string Year { get; set; }
        public string Month { get; set; }

        public int Status { get; private set; }

        public BillGenerateHistory() { }

        public BillGenerateHistory(string year,string month)
        {
            Year = year;
            Month = month;
        }

        public void UpdateBillGenerateHistory(string year, string month)
        {
            Year = year;
            Month = month;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}