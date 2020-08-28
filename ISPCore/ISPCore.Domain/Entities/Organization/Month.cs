using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class Month : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public string MonthName { get; private set; }

        public int Status { get; private set; }


        public Month() { }

        public Month(string monthName)
        {
            MonthName = monthName;
        }

        public void UpdateMonth(string monthName)
        {
            MonthName = monthName;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
