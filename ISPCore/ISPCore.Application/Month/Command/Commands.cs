using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Month.Command
{
    public static class Commands
    {
        public static class Month
        {
            public class Create : IRequest<MonthCommandVM>
            {
                public string MonthName { get; set; }
            }

            public class Update : IRequest<MonthCommandVM>
            {
                public int Id { get; set; }
                public string MonthName { get; set; }
            }

            public class MarkAsDelete : IRequest<MonthCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
