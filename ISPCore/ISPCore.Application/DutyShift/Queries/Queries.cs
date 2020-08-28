using ISPCore.Application.DutyShift.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.DutyShift.Queries
{
    public static class Queries
    {
        public class GetDutyShiftList : IRequest<List<DutyShiftVM>>
        {
        }
        public class GetDutyShift : IRequest<DutyShiftVM>
        {
            public int Id { get; set; }
        }
    }
}
