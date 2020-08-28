using ISPCore.Application.AccountList.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.AccountList.Queries
{
    public static class Queries
    {
        public class GetAccountListList : IRequest<List<AccountListVM>>
        {
        }
        public class GetAccountList : IRequest<AccountListVM>
        {
            public int Id { get; set; }
        }
    }
}
