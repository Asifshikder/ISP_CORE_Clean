using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class CableType : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public string CableTypeName { get; private set; }

        public int Status { get; private set; }


        public CableType() { }

        public CableType(string cableTypeName)
        {
            CableTypeName = cableTypeName;
        }

        public void UpdateCableType(string cableTypeName)
        {
            CableTypeName = cableTypeName;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
