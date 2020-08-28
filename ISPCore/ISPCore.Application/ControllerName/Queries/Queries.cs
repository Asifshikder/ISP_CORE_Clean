using ISPCore.Application.ControllerName.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ControllerName.Queries
{
    public static class Queries
    {
        public class GetControllerNameList : IRequest<List<ControllerNameVM>>
        {
        }
        public class GetControllerName : IRequest<ControllerNameVM>
        {
            public int Id { get; set; }
        }
    }
}
