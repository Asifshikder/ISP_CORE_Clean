using ISPCore.Application.FormNameForAuth.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.FormNameForAuth.Queries
{
    public static class Queries
    {
        public class GetFormNameForAuthList : IRequest<List<FormNameForAuthVM>>
        {
        }
        public class GetFormNameForAuth : IRequest<FormNameForAuthVM>
        {
            public int Id { get; set; }
        }
    }
}
