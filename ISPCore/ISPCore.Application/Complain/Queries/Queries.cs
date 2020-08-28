using ISPCore.Application.Complain.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Complain.Queries
{
    public static class Queries
    {
        public class GetComplainList : IRequest<List<ComplainVM>>
        {
        }
        public class GetComplain : IRequest<ComplainVM>
        {
            public int Id { get; set; }
        }
    }
}
