using ISPCore.Application.LineStatus.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.LineStatus.Queries
{
    public static class Queries
    {
        public class GetLineStatusList : IRequest<List<LineStatusVM>>
        {
        }
        public class GetLineStatus : IRequest<LineStatusVM>
        {
            public int Id { get; set; }
        }
    }
}
