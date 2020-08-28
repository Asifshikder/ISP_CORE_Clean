using ISPCore.Application.Company.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Company.Queries
{
    public static class Queries
    {
        public class GetCompanyList : IRequest<List<CompanyVM>>
        {
        }
        public class GetCompany : IRequest<CompanyVM>
        {
            public int Id { get; set; }
        }
    }
}
