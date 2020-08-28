using ISPCore.Application.ClientDetails.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ClientDetails.Queries
{
    public static class Queries
    {
        public class GetClientDetailsList : IRequest<List<ClientDetailsVM>>
        {
        }
        public class GetClientDetails : IRequest<ClientDetailsVM>
        {
            public int Id { get; set; }
        }
    }
}
