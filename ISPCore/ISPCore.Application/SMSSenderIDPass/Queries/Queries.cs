using ISPCore.Application.SMSSenderIDPass.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.SMSSenderIDPass.Queries
{
    public static class Queries
    {
        public class GetSMSSenderIDPassList : IRequest<List<SMSSenderIDPassVM>>
        {
        }
        public class GetSMSSenderIDPass : IRequest<SMSSenderIDPassVM>
        {
            public int Id { get; set; }
        }
    }
}
