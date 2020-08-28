using ISPCore.Application.Form.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Form.Queries
{
    public static class Queries
    {
        public class GetFormList : IRequest<List<FormVM>>
        {
        }
        public class GetForm : IRequest<FormVM>
        {
            public int Id { get; set; }
        }
    }
}
