using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class SMS : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public string SMSTitle { get; set; }
        public string SendMessageText { get; set; }
        public string SMSCode { get; set; }
        public string Sender { get; set; }
        public int SMSStatus { get; set; }
        public int SMSCounter { get; set; }

        public int Status { get; private set; }

        public SMS() { }

        public SMS(string sMSTitle, string sendMessageText,string sMSCode, string sender, int sMSStatus, int sMSCounter)
        {
            SMSTitle = sMSTitle;
            SendMessageText = sendMessageText;
            SMSCode = sMSCode;
            Sender = sender;
            SMSStatus = sMSStatus;
            SMSCounter = sMSCounter;
        }

        public void UpdateSMS(string sMSTitle, string sendMessageText, string sMSCode, string sender, int sMSStatus, int sMSCounter)
        {
            SMSTitle = sMSTitle;
            SendMessageText = sendMessageText;
            SMSCode = sMSCode;
            Sender = sender;
            SMSStatus = sMSStatus;
            SMSCounter = sMSCounter;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
