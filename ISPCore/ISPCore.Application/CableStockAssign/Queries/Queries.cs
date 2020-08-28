using ISPCore.Application.ClientStockAssign.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ClientStockAssign.Queries
{
    public static class Queries
    {
        public class GetClientStockAssignList : IRequest<List<ClientStockAssignVM>>
        {
        }
        public class GetClientStockAssign : IRequest<ClientStockAssignVM>
        {
            public int Id { get; set; }
        }
    }
}
