using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.CableType.Command
{
    public static class Commands
    {
        public static class CableType
        {
            public class Create : IRequest<CableTypeCommandVM>
            {
                public string CableTypeName { get; set; }
            }

            public class Update : IRequest<CableTypeCommandVM>
            {
                public int Id { get; set; }
                public string CableTypeName { get; set; }
            }

            public class MarkAsDelete : IRequest<CableTypeCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
