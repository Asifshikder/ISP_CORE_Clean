using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Year.Command
{
    public static class Commands
    {
        public static class Year
        {
            public class Create : IRequest<YearCommandVM>
            {
                public string YearName { get; set; }
            }

            public class Update : IRequest<YearCommandVM>
            {
                public int Id { get; set; }
                public string YearName { get; set; }
            }

            public class MarkAsDelete : IRequest<YearCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
