using ISPCore.Application.CableUnit.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.CableUnit.Queries
{
    public static class Queries
    {
        public class GetCableUnitList : IRequest<List<CableUnitVM>>
        {
        }
        public class GetCableUnit : IRequest<CableUnitVM>
        {
            public int Id { get; set; }
        }
    }
}
