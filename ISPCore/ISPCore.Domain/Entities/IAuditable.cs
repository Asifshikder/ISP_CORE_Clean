using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain
{
    public interface IAuditable
    {
        DateTime CreateDate { get; set; }
        Guid CreateBy { get; set; }
        DateTime UpdateDate { get; set; }
        Guid UpdateBy { get; set; } 
    }
}
