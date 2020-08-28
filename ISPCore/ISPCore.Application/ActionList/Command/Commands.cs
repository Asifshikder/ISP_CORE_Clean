using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ActionList.Command
{
    public static class Commands
    {
        public static class ActionList
        {
            public class Create : IRequest<ActionListCommandVM>
            {
                public int FormID { get; set; }
                public string ActionName { get; set; }
                public string ActionValue { get; set; }
                public string ActionDescription { get; set; }
            }

            public class Update : IRequest<ActionListCommandVM>
            {
                public int Id { get; set; }
                public int FormID { get; set; }
                public string ActionName { get; set; }
                public string ActionValue { get; set; }
                public string ActionDescription { get; set; }
            }

            public class MarkAsDelete : IRequest<ActionListCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
