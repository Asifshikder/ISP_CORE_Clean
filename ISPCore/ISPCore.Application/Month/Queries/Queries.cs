using ISPCore.Application.Month.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Month.Queries
{
    public static class Queries
    {
        public class GetMonthList : IRequest<List<MonthVM>>
        {
        }
        public class GetMonth : IRequest<MonthVM>
        {
            public int Id { get; set; }
        }
    }
}
