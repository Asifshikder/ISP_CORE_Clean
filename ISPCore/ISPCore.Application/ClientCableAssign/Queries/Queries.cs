using ISPCore.Application.ClientCableAssign.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ClientCableAssign.Queries
{
    public static class Queries
    {
        public class GetClientCableAssignList : IRequest<List<ClientCableAssignVM>>
        {
        }
        public class GetClientCableAssign : IRequest<ClientCableAssignVM>
        {
            public int Id { get; set; }
        }
    }
}
