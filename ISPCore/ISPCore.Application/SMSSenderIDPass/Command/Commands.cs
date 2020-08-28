using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.SMSSenderIDPass.Command
{
    public static class Commands
    {
        public static class SMSSenderIDPass
        {
            public class Create : IRequest<SMSSenderIDPassCommandVM>
            {

                public string SenderID { get; set; }
                public string Pass { get; set; }
                public string Sender { get; set; }
                public string CompanyName { get; set; }
                public string HelpLine { get; set; }
            }

            public class Update : IRequest<SMSSenderIDPassCommandVM>
            {
                public int Id { get; set; }
                public string SenderID { get; set; }
                public string Pass { get; set; }
                public string Sender { get; set; }
                public string CompanyName { get; set; }
                public string HelpLine { get; set; }
            }

            public class MarkAsDelete : IRequest<SMSSenderIDPassCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
