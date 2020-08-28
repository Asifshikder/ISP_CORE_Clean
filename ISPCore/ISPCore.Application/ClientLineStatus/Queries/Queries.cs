using ISPCore.Application.ClientLineStatus.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ClientLineStatus.Queries
{
    public static class Queries
    {
        public class GetClientLineStatusList : IRequest<List<ClientLineStatusVM>>
        {
        }
        public class GetClientLineStatus : IRequest<ClientLineStatusVM>
        {
            public int Id { get; set; }
        }
    }
}
