using ISPCore.Domain.Entities;
using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic; 
using System.Linq;
using System.Web;

namespace ISPCore.Domain.Entities
{
    public class Day : BaseEntity, IHasId<int>, IAggregateRoot
    { 
        //public int DayID { get; set; }
        public int Id { get; private set; }
        public string DayName { get; set; }

        public int Status { get; private set; }

        public Day() { }

        public Day(string dayName)
        {
            DayName = dayName;
        }

        public void UpdateDay(string dayName)
        {
            DayName = dayName;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}