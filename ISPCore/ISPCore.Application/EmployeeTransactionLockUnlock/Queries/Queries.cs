using ISPCore.Application.EmployeeTransactionLockUnlock.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.EmployeeTransactionLockUnlock.Queries
{
    public static class Queries
    {
        public class GetEmployeeTransactionLockUnlockList : IRequest<List<EmployeeTransactionLockUnlockVM>>
        {
        }
        public class GetEmployeeTransactionLockUnlock : IRequest<EmployeeTransactionLockUnlockVM>
        {
            public int Id { get; set; }
        }
    }
}
