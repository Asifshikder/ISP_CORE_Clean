using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Mikrotik.Command
{
    public static class Commands
    {
        public static class Mikrotik
        {
            public class Create : IRequest<MikrotikCommandVM>
            {
                public string MikrotikName { get; set; }

                public string RealIP { get; set; }
                public string MikUserName { get; set; }
                public string MikPassword { get; set; }
                public int APIPort { get; set; }
                public int WebPort { get; set; }
            }

            public class Update : IRequest<MikrotikCommandVM>
            {
                public int Id { get; set; }
                public string MikrotikName { get; set; }

                public string RealIP { get; set; }
                public string MikUserName { get; set; }
                public string MikPassword { get; set; }
                public int APIPort { get; set; }
                public int WebPort { get; set; }
            }

            public class MarkAsDelete : IRequest<MikrotikCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
