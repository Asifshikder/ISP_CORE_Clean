using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Form.Command
{
    public static class Commands
    {
        public static class Form
        {
            public class Create : IRequest<FormCommandVM>
            {
                public string FormName { get; set; }
                public int ControllerNameID { get; set; }
                public string FormValue { get; set; }
                public string FormDescription { get; set; }
                public string FormLocation { get; set; }
            }

            public class Update : IRequest<FormCommandVM>
            {
                public int Id { get; set; }
                public string FormName { get; set; }
                public int ControllerNameID { get; set; }
                public string FormValue { get; set; }
                public string FormDescription { get; set; }
                public string FormLocation { get; set; }
            }

            public class MarkAsDelete : IRequest<FormCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
