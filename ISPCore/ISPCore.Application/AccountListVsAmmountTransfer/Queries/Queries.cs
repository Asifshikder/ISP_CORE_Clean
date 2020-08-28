using ISPCore.Application.AccountListVsAmmountTransfer.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.AccountListVsAmmountTransfer.Queries
{
    public static class Queries
    {
        public class GetAccountListVsAmmountTransferList : IRequest<List<AccountListVsAmmountTransferVM>>
        {
        }
        public class GetAccountListVsAmmountTransfer : IRequest<AccountListVsAmmountTransferVM>
        {
            public int Id { get; set; }
        }
    }
}
