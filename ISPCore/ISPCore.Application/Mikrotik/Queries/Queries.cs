using ISPCore.Application.Mikrotik.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Mikrotik.Queries
{
    public static class Queries
    {
        public class GetMikrotikList : IRequest<List<MikrotikVM>>
        {
        }
        public class GetMikrotik : IRequest<MikrotikVM>
        {
            public int Id { get; set; }
        }
    }
}
