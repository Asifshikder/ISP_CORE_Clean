using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class MeasurementUnit : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public string MeasurementUnitName { get; private set; }

        public int Status { get; private set; }


        public MeasurementUnit() { }

        public MeasurementUnit(string measurementUnitName)
        {
            MeasurementUnitName = measurementUnitName;
        }

        public void UpdateMeasurementUnit(string measurementUnitName)
        {
            MeasurementUnitName = measurementUnitName;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
