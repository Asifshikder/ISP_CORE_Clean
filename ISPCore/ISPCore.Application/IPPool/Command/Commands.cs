using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.IPPool.Command
{
    public static class Commands
    {
        public static class IPPool
        {
            public class Create : IRequest<IPPoolCommandVM>
            {
                public string IPPoolName { get; set; }
                public string StartRange { get; set; }
                public string EndRange { get; set; }
            }

            public class Update : IRequest<IPPoolCommandVM>
            {
                public int Id { get; set; }
                public string IPPoolName { get; set; }
                public string StartRange { get; set; }
                public string EndRange { get; set; }
            }

            public class MarkAsDelete : IRequest<IPPoolCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
