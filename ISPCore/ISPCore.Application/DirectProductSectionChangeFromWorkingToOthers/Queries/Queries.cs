using ISPCore.Application.DirectProductSectionChangeFromWorkingToOthers.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.DirectProductSectionChangeFromWorkingToOthers.Queries
{
    public static class Queries
    {
        public class GetDirectProductSectionChangeFromWorkingToOthersList : IRequest<List<DirectProductSectionChangeFromWorkingToOthersVM>>
        {
        }
        public class GetDirectProductSectionChangeFromWorkingToOthers : IRequest<DirectProductSectionChangeFromWorkingToOthersVM>
        {
            public int Id { get; set; }
        }
    }
}
