using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.LineStatus.Command
{
    public static class Commands
    {
        public static class LineStatus
        {
            public class Create : IRequest<LineStatusCommandVM>
            {
                public string LineStatusName { get; set; }
            }

            public class Update : IRequest<LineStatusCommandVM>
            {
                public int Id { get; set; }
                public string LineStatusName { get; set; }
            }

            public class MarkAsDelete : IRequest<LineStatusCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
