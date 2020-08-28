using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ConnectionType.Command
{
    public static class Commands
    {
        public static class ConnectionType
        {
            public class Create : IRequest<ConnectionTypeCommandVM>
            {
                public string ConnectionTypeName { get; set; }
            }

            public class Update : IRequest<ConnectionTypeCommandVM>
            {
                public int Id { get; set; }
                public string ConnectionTypeName { get; set; }
            }

            public class MarkAsDelete : IRequest<ConnectionTypeCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
