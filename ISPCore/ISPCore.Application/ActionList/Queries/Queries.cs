using ISPCore.Application.ActionList.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ActionList.Queries
{
    public static class Queries
    {
        public class GetActionListList : IRequest<List<ActionListVM>>
        {
        }
        public class GetActionList : IRequest<ActionListVM>
        {
            public int Id { get; set; }
        }
    }
}
