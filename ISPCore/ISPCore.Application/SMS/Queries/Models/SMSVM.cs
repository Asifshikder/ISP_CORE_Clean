using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.SMS.Queries.Models
{
    public class SMSVM
    {
        public int Id { get; set; }
        public string SMSTitle { get; set; }
        public string SendMessageText { get; set; }
        public string SMSCode { get; set; }
        public string Sender { get; set; }
        public int SMSStatus { get; set; }
        public int SMSCounter { get; set; }
    }
}
