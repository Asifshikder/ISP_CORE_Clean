using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ComplainType.Command
{
    public static class Commands
    {
        public static class ComplainType
        {
            public class Create : IRequest<ComplainTypeCommandVM>
            {
                public string ComplainTypeName { get; set; }
                public bool ShowMessageBox { get; set; }
            }

            public class Update : IRequest<ComplainTypeCommandVM>
            {
                public int Id { get; set; }
                public string ComplainTypeName { get; set; }
                public bool ShowMessageBox { get; set; }
            }

            public class MarkAsDelete : IRequest<ComplainTypeCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
