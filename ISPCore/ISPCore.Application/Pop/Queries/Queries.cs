using ISPCore.Application.Pop.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Pop.Queries
{
    public static class Queries
    {
        public class GetPopList : IRequest<List<PopVM>>
        {
        }
        public class GetPop : IRequest<PopVM>
        {
            public int Id { get; set; }
        }
    }
}
