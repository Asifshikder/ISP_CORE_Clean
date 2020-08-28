using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ClientCableDistribution.Command
{
    public static class Commands
    {
        public static class ClientCableDistribution
        {
            public class Create : IRequest<ClientCableDistributionCommandVM>
            {
                public int CableQuantity { get; set; }
                public int? EmployeeID { get; set; }
                public int? ClientID { get; set; }
                public int? AssignEmployee { get; set; }
            }

            public class Update : IRequest<ClientCableDistributionCommandVM>
            {
                public int Id { get; set; }
                public int CableQuantity { get; set; }
                public int? EmployeeID { get; set; }
                public int? ClientID { get; set; }
                public int? AssignEmployee { get; set; }
            }

            public class MarkAsDelete : IRequest<ClientCableDistributionCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
