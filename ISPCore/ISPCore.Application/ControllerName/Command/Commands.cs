using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ControllerName.Command
{
    public static class Commands
    {
        public static class ControllerName
        {
            public class Create : IRequest<ControllerNameCommandVM>
            {
                public string ControllerNames { get; set; }
                public string ControllerValue { get; set; }
            }

            public class Update : IRequest<ControllerNameCommandVM>
            {
                public int Id { get; set; }
                public string ControllerNames { get; set; }
                public string ControllerValue { get; set; }
            }

            public class MarkAsDelete : IRequest<ControllerNameCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
