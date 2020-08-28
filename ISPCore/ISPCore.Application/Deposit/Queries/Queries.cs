using ISPCore.Application.Deposit.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Deposit.Queries
{
    public static class Queries
    {
        public class GetDepositList : IRequest<List<DepositVM>>
        {
        }
        public class GetDeposit : IRequest<DepositVM>
        {
            public int Id { get; set; }
        }
    }
}
