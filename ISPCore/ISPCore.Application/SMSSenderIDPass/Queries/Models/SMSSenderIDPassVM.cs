using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.SMSSenderIDPass.Queries.Models
{
    public class SMSSenderIDPassVM
    {
        public int Id { get; set; }
        public string SenderID { get; set; }
        public string Pass { get; set; }
        public string Sender { get; set; }
        public string CompanyName { get; set; }
        public string HelpLine { get; set; }
    }
}
