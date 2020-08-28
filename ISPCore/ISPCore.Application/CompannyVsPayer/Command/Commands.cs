using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.CompanyVsPayer.Command
{
    public static class Commands
    {
        public static class CompanyVsPayer
        {
            public class Create : IRequest<CompanyVsPayerCommandVM>
            {
                public string CompanyVsPayerName { get; set; }
                public int CompanyID { get; set; }
            }

            public class Update : IRequest<CompanyVsPayerCommandVM>
            {
                public int Id { get; set; }
                public string CompanyVsPayerName { get; set; }
                public int CompanyID { get; set; }
            }

            public class MarkAsDelete : IRequest<CompanyVsPayerCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
