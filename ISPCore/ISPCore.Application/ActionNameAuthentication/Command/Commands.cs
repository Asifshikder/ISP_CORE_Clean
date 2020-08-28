using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ActionNameAuthentication.Command
{
    public static class Commands
    {
        public static class ActionNameAuthentication
        {
            public class Create : IRequest<ActionNameAuthenticationCommandVM>
            {
                public string ActionName { get; set; }
                public bool IsGranted { get; set; }
                public string ID { get; set; }
                public string Text { get; set; }
                public bool @Checked { get; set; }
                public int Status { get; private set; }
            }

            public class Update : IRequest<ActionNameAuthenticationCommandVM>
            {
                public int Id { get; set; }
                public string ActionName { get; set; }
                public bool IsGranted { get; set; }
                public string ID { get; set; }
                public string Text { get; set; }
                public bool @Checked { get; set; }
                public int Status { get; private set; }
            }

            public class MarkAsDelete : IRequest<ActionNameAuthenticationCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
