using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Day.Command
{
    public static class Commands
    {
        public static class Day
        {
            public class Create : IRequest<DayCommandVM>
            {
                public string DayName { get; set; }
            }

            public class Update : IRequest<DayCommandVM>
            {
                public int Id { get; set; }
                public string DayName { get; set; }
            }

            public class MarkAsDelete : IRequest<DayCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
