using ISPCore.Application.ClientDueBills.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ClientDueBills.Queries
{
    public static class Queries
    {
        public class GetClientDueBillsList : IRequest<List<ClientDueBillsVM>>
        {
        }
        public class GetClientDueBills : IRequest<ClientDueBillsVM>
        {
            public int Id { get; set; }
        }
    }
}
