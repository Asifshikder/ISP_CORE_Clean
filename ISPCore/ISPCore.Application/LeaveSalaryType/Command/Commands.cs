using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.LeaveSalaryType.Command
{
    public static class Commands
    {
        public static class LeaveSalaryType
        {
            public class Create : IRequest<LeaveSalaryTypeCommandVM>
            {
                public string LeaveSalaryTypeName { get; set; }
                public decimal Percentage { get; set; }
            }

            public class Update : IRequest<LeaveSalaryTypeCommandVM>
            {
                public int Id { get; set; }
                public string LeaveSalaryTypeName { get; set; }
                public decimal Percentage { get; set; }
            }

            public class MarkAsDelete : IRequest<LeaveSalaryTypeCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
