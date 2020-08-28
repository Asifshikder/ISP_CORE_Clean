using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Section.Command
{
    public static class Commands
    {
        public static class Section
        {
            public class Create : IRequest<SectionCommandVM>
            {
                public string SectionName { get; set; }
            }

            public class Update : IRequest<SectionCommandVM>
            {
                public int Id { get; set; }
                public string SectionName { get; set; }
            }

            public class MarkAsDelete : IRequest<SectionCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
