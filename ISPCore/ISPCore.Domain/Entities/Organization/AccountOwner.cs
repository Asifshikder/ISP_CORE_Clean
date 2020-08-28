using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class AccountOwner : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public string AccountOwnerName { get; private set; }

        public int Status { get; private set; }


        public AccountOwner() { }

        public AccountOwner(string accountOwnerName)
        {
            AccountOwnerName = accountOwnerName;
        }

        public void UpdateAccountOwner(string accountOwnerName)
        {
            AccountOwnerName = accountOwnerName;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
