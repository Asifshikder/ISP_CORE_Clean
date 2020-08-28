using ISPCore.Application.Head.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Head.Queries
{
    public static class Queries
    {
        public class GetHeadList : IRequest<List<HeadVM>>
        {
        }
        public class GetHead : IRequest<HeadVM>
        {
            public int Id { get; set; }
        }
    }
}
