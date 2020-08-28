using ISPCore.Application.ISPAccessList.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ISPAccessList.Queries
{
    public static class Queries
    {
        public class GetISPAccessListList : IRequest<List<ISPAccessListVM>>
        {
        }
        public class GetISPAccessList : IRequest<ISPAccessListVM>
        {
            public int Id { get; set; }
        }
    }
}
