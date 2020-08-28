using ISPCore.Application.ConnectionType.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ConnectionType.Queries
{
    public static class Queries
    {
        public class GetConnectionTypeList : IRequest<List<ConnectionTypeVM>>
        {
        }
        public class GetConnectionType : IRequest<ConnectionTypeVM>
        {
            public int Id { get; set; }
        }
    }
}
