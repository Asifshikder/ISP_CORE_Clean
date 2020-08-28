using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Head.Command
{
    public static class Commands
    {
        public static class Head
        {
            public class Create : IRequest<HeadCommandVM>
            {
                public string HeadName { get; set; }
                public int HeadTypeID { get; set; }
                public int? ResellerID { get; set; }
            }

            public class Update : IRequest<HeadCommandVM>
            {
                public int Id { get; set; }
                public string HeadName { get; set; }
                public int HeadTypeID { get; set; }
                public int? ResellerID { get; set; }
            }

            public class MarkAsDelete : IRequest<HeadCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
