using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class CompanyVsPayer : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public string CompanyVsPayerName { get; private set; }
        public int CompanyID { get; set; }
        public virtual Company Company { get; set; }
        public int Status { get; private set; }


        public CompanyVsPayer() { }

        public CompanyVsPayer(string companyVsPayerName,int companyID)
        {
            CompanyVsPayerName = companyVsPayerName;
            CompanyID = companyID;
        }

        public void UpdateComapnyVsPayer(string companyVsPayerName, int companyID)
        {
            CompanyVsPayerName = companyVsPayerName;
            CompanyID = companyID;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
