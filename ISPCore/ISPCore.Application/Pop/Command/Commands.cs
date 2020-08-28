using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Pop.Command
{
    public static class Commands
    {
        public static class Pop
        {
            public class Create : IRequest<PopCommandVM>
            {
                public string PopName { get; set; }
                public string PopLocation { get; set; }

            }

            public class Update : IRequest<PopCommandVM>
            {
                public int Id { get; set; }
                public string PopName { get; set; }
                public string PopLocation { get; set; }

            }

            public class MarkAsDelete : IRequest<PopCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
