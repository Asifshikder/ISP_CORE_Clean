using ISPCore.Application.CompanyVsPayer.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.CompanyVsPayer.Queries
{
    public static class Queries
    {
        public class GetCompanyVsPayerList : IRequest<List<CompanyVsPayerVM>>
        {
        }
        public class GetCompanyVsPayer : IRequest<CompanyVsPayerVM>
        {
            public int Id { get; set; }
        }
    }
}
