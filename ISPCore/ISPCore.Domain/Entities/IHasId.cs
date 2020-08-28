using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public interface IHasId<out TId>
    {
        TId Id { get; }
    }
}
