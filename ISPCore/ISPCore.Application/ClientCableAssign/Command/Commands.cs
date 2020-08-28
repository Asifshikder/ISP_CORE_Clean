using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ClientCableAssign.Command
{
    public static class Commands
    {
        public static class ClientCableAssign
        {
            public class Create : IRequest<ClientCableAssignCommandVM>
            {
                public int CableQuantity { get; set; }
                public int EmployeeID { get; set; }
            }

            public class Update : IRequest<ClientCableAssignCommandVM>
            {
                public int Id { get; set; }
                public int CableQuantity { get; set; }
                public int EmployeeID { get; set; }
            }

            public class MarkAsDelete : IRequest<ClientCableAssignCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
