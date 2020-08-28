using ISPCore.Application.Year.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Year.Queries
{
    public static class Queries
    {
        public class GetYearList : IRequest<List<YearVM>>
        {
        }
        public class GetYear : IRequest<YearVM>
        {
            public int Id { get; set; }
        }
    }
}
