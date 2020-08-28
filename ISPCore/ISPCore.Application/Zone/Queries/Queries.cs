using ISPCore.Application.Zone.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Zone.Queries
{
    public static class Queries
    {
        public class GetZoneList : IRequest<List<ZoneVM>>
        {
        }
        public class GetZone : IRequest<ZoneVM>
        {
            public int Id { get; set; }
        }
    }
}
