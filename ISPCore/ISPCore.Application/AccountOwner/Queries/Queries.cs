using ISPCore.Application.AccountOwner.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.AccountOwner.Queries
{
    public static class Queries
    {
        public class GetAccountOwnerList : IRequest<List<AccountOwnerVM>>
        {
        }
        public class GetAccountOwner : IRequest<AccountOwnerVM>
        {
            public int Id { get; set; }
        }
    }
}
