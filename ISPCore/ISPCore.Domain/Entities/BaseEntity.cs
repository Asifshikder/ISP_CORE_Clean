using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class BaseEntity
    {
        public DateTime CreateDate { get; set; }
        public Guid CreateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public Guid UpdateBy { get; set; }
    }
}
