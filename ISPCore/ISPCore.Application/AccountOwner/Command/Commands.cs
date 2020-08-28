using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.AccountOwner.Command
{
    public static class Commands
    {
        public static class AccountOwner
        {
            public class Create : IRequest<AccountOwnerCommandVM>
            {
                public string AccountOwnerName { get; set; }
            }

            public class Update : IRequest<AccountOwnerCommandVM>
            {
                public int Id { get; set; }
                public string AccountOwnerName { get; set; }
            }

            public class MarkAsDelete : IRequest<AccountOwnerCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
