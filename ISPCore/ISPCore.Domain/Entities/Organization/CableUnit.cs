using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class CableUnit : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public string CableUnitName { get; private set; }

        public int Status { get; private set; }


        public CableUnit() { }

        public CableUnit(string cableUnitName)
        {
            CableUnitName = cableUnitName;
        }

        public void UpdateCableUnit(string cableUnitName)
        {
            CableUnitName = cableUnitName;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
