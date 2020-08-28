using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.CableUnit.Command
{
    public static class Commands
    {
        public static class CableUnit
        {
            public class Create : IRequest<CableUnitCommandVM>
            {
                public string CableUnitName { get; set; }
            }

            public class Update : IRequest<CableUnitCommandVM>
            {
                public int Id { get; set; }
                public string CableUnitName { get; set; }
            }

            public class MarkAsDelete : IRequest<CableUnitCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
