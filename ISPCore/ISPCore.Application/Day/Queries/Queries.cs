using ISPCore.Application.Day.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Day.Queries
{
    public static class Queries
    {
        public class GetDayList : IRequest<List<DayVM>>
        {
        }
        public class GetDay : IRequest<DayVM>
        {
            public int Id { get; set; }
        }
    }
}
