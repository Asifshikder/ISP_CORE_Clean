using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ISPAccessList.Command
{
    public static class Commands
    {
        public static class ISPAccessList
        {
            public class Create : IRequest<ISPAccessListCommandVM>
            {
                public string AccessName { get; set; }
                public int AccessValue { get; set; }
                public bool IsGranted { get; set; }

            }

            public class Update : IRequest<ISPAccessListCommandVM>
            {
                public int Id { get; set; }
                public string AccessName { get; set; }
                public int AccessValue { get; set; }
                public bool IsGranted { get; set; }

            }

            public class MarkAsDelete : IRequest<ISPAccessListCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
