using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.SMS.Command
{
    public static class Commands
    {
        public static class SMS
        {
            public class Create : IRequest<SMSCommandVM>
            {
                public string SMSTitle { get; set; }
                public string SendMessageText { get; set; }
                public string SMSCode { get; set; }
                public string Sender { get; set; }
                public int SMSStatus { get; set; }
                public int SMSCounter { get; set; }
            }

            public class Update : IRequest<SMSCommandVM>
            {
                public int Id { get; set; }
                public string SMSTitle { get; set; }
                public string SendMessageText { get; set; }
                public string SMSCode { get; set; }
                public string Sender { get; set; }
                public int SMSStatus { get; set; }
                public int SMSCounter { get; set; }
            }

            public class MarkAsDelete : IRequest<SMSCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
