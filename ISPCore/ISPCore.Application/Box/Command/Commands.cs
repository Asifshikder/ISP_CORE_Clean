using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Box.Command
{
    public static class Commands
    {
        public static class Box
        {
            public class Create : IRequest<BoxCommandVM>
            {
                public string BoxName { get; set; }
                public int? ResellerID { get; set; }
                public string BoxLocation { get; set; }
            }

            public class Update : IRequest<BoxCommandVM>
            {
                public int Id { get; set; }
                public string BoxName { get; set; }
                public int? ResellerID { get; set; }
                public string BoxLocation { get; set; }
            }

            public class MarkAsDelete : IRequest<BoxCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
