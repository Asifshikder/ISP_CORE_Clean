using ISPCore.Application.MeasurementUnit.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.MeasurementUnit.Queries
{
    public static class Queries
    {
        public class GetMeasurementUnitList : IRequest<List<MeasurementUnitVM>>
        {
        }
        public class GetMeasurementUnit : IRequest<MeasurementUnitVM>
        {
            public int Id { get; set; }
        }
    }
}
