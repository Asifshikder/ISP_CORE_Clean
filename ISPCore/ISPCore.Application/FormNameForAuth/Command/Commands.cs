using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.FormNameForAuth.Command
{
    public static class Commands
    {
        public static class FormNameForAuth
        {
            public class Create : IRequest<FormNameForAuthCommandVM>
            {
                public string FormName { get; set; }
                public bool IsGranted { get; set; }
                public string ID { get; set; }
                public string Text { get; set; }
                public bool @Checked { get; set; }
            }

            public class Update : IRequest<FormNameForAuthCommandVM>
            {
                public int Id { get; set; }
                public string FormName { get; set; }
                public bool IsGranted { get; set; }
                public string ID { get; set; }
                public string Text { get; set; }
                public bool @Checked { get; set; }
            }

            public class MarkAsDelete : IRequest<FormNameForAuthCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
