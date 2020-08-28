using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class SMSSenderIDPass : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public string SenderID { get; set; }
        public string Pass { get; set; }
        public string Sender { get; set; }
        public string CompanyName { get; set; }
        public string HelpLine { get; set; }

        public int Status { get; private set; }

        public SMSSenderIDPass() { }

        public SMSSenderIDPass(string senderID , string pass ,string sender ,string companyName,string helpLine)
        {
            SenderID = senderID;
            Pass = pass;
            Sender = sender;
            CompanyName = companyName;
            HelpLine = helpLine;

        }

        public void UpdateSMSSenderIDPass( string senderID, string pass, string sender, string companyName, string helpLine)
        {
            SenderID = senderID;

            Pass = pass;
            Sender = sender;
            CompanyName = companyName;
            HelpLine = helpLine;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
