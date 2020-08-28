using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Interfaces
{
    public interface ILoggedInUserIdentity
    {
        Guid UserId { get; }
        bool IsAuthenticated { get; }
    }
}
