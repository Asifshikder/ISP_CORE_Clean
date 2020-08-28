using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class Pop : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public string PopName { get; set; }
        public string PopLocation { get; set; }

        public int Status { get; private set; }

        public Pop() { }

        public Pop(string popName, string popLocation)
        {
            PopName = popName;
            PopLocation = popLocation;
            
        }

        public void UpdatePop(string popName, string popLocation)
        {
            PopName = popName;
            PopLocation = popLocation;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
