using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Company.Command
{
    public static class Commands
    {
        public static class Company
        {
            public class Create : IRequest<CompanyCommandVM>
            {
                public string CompanyName { get; set; }
                public string CompanyEmail { get; set; }
                public string CompanyAddress { get; set; }
                public string ContactPerson { get; set; }
                public string Phone { get; set; }
                public byte[] CompanyLogo { get; set; }
                public string CompanyLogoPath { get; set; }
            }

            public class Update : IRequest<CompanyCommandVM>
            {
                public int Id { get; set; }
                public string CompanyName { get; set; }
                public string CompanyEmail { get; set; }
                public string CompanyAddress { get; set; }
                public string ContactPerson { get; set; }
                public string Phone { get; set; }
                public byte[] CompanyLogo { get; set; }
                public string CompanyLogoPath { get; set; }
            }

            public class MarkAsDelete : IRequest<CompanyCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
