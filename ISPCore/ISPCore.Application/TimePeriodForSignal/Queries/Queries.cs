using ISPCore.Application.TimePeriodForSignal.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.TimePeriodForSignal.Queries
{
    public static class Queries
    {
        public class GetTimePeriodForSignalList : IRequest<List<TimePeriodForSignalVM>>
        {
        }
        public class GetTimePeriodForSignal : IRequest<TimePeriodForSignalVM>
        {
            public int Id { get; set; }
        }
    }
}
