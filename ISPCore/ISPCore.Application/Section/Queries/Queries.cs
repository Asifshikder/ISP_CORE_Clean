using ISPCore.Application.Section.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Section.Queries
{
    public static class Queries
    {
        public class GetSectionList : IRequest<List<SectionVM>>
        {
        }
        public class GetSection : IRequest<SectionVM>
        {
            public int Id { get; set; }
        }
    }
}
