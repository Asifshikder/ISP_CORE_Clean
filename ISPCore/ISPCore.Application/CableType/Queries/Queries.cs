using ISPCore.Application.CableType.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.CableType.Queries
{
    public static class Queries
    {
        public class GetCableTypeList : IRequest<List<CableTypeVM>>
        {
        }
        public class GetCableType : IRequest<CableTypeVM>
        {
            public int Id { get; set; }
        }
    }
}
