using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Zone.Command
{
    public static class Commands
    {
        public static class Zone
        {
            public class Create : IRequest<ZoneCommandVM>
            {
                public string ZoneName { get; set; }
                public int? ResellerID { get; set; }
            }

            public class Update : IRequest<ZoneCommandVM>
            {
                public int Id { get; set; }
                public string ZoneName { get; set; }
                public int? ResellerID { get; set; }
            }

            public class MarkAsDelete : IRequest<ZoneCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
