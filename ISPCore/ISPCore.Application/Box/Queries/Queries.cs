using ISPCore.Application.Box.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Box.Queries
{
    public static class Queries
    {
        public class GetBoxList : IRequest<List<BoxVM>>
        {
        }
        public class GetBox : IRequest<BoxVM>
        {
            public int Id { get; set; }
        }
    }
}
