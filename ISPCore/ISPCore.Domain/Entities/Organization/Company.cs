using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class Company : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public string CompanyName { get; private set; }
        public string CompanyEmail { get; set; }
        public string CompanyAddress { get; set; }
        public string ContactPerson { get; set; }
        public string Phone { get; set; }
        public byte[] CompanyLogo { get; set; }
        public string CompanyLogoPath { get; set; }
        public int Status { get; private set; }


        public Company() { }

        public Company(string companyName, string companyEmail,string companyAddress, string contactPerson, string phone, byte[] companyLogo, string companyLogoPath)
        {
            CompanyName = companyName;
            CompanyEmail = companyEmail;
            CompanyAddress = companyAddress;
            ContactPerson = contactPerson;
            Phone = phone;
            CompanyLogo = companyLogo;
            CompanyLogoPath = companyLogoPath;
        }

        public void UpdateCompany(string companyName, string companyEmail, string companyAddress, string contactPerson, string phone, byte[] companyLogo, string companyLogoPath)
        {
            CompanyName = companyName;
            CompanyEmail = companyEmail;
            CompanyAddress = companyAddress;
            ContactPerson = contactPerson;
            Phone = phone;
            CompanyLogo = companyLogo;
            CompanyLogoPath = companyLogoPath;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
