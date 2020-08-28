using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class Year : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public string YearName { get; private set; }

        public int Status { get; private set; } 


        public Year() { }

        public Year(string yearName)
        {
            YearName = yearName;
        }

        public void UpdateYear(string yearName)
        {
            YearName = yearName;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
