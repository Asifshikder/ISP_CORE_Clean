using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.MeasurementUnit.Command
{
    public static class Commands
    {
        public static class MeasurementUnit
        {
            public class Create : IRequest<MeasurementUnitCommandVM>
            {
                public string MeasurementUnitName { get; set; }
            }

            public class Update : IRequest<MeasurementUnitCommandVM>
            {
                public int Id { get; set; }
                public string MeasurementUnitName { get; set; }
            }

            public class MarkAsDelete : IRequest<MeasurementUnitCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
