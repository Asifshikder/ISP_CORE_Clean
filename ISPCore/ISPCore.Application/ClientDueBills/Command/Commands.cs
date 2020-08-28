using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ClientDueBills.Command
{
    public static class Commands
    {
        public static class ClientDueBills
        {
            public class Create : IRequest<ClientDueBillsCommandVM>
            {
                public int ClientDetailsID { get; set; }
                public double DueAmount { get; set; }
                public int Year { get; set; }
                public int Month { get; set; }
            }

            public class Update : IRequest<ClientDueBillsCommandVM>
            {
                public int Id { get; set; }
                public int ClientDetailsID { get; set; }
                public double DueAmount { get; set; }
                public int Year { get; set; }
                public int Month { get; set; }
            }

            public class MarkAsDelete : IRequest<ClientDueBillsCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
