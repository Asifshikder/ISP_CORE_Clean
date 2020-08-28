using ISPCore.Application.ComplainType.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ComplainType.Queries
{
    public static class Queries
    {
        public class GetComplainTypeList : IRequest<List<ComplainTypeVM>>
        {
        }
        public class GetComplainType : IRequest<ComplainTypeVM>
        {
            public int Id { get; set; }
        }
    }
}
