using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class LineStatus : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public string LineStatusName { get; private set; }

        public int Status { get; private set; }

        public virtual ICollection<Complain> Complain { get; set; }

        public LineStatus() { }

        public LineStatus(string lineStatusName)
        {
            LineStatusName = lineStatusName;
        }

        public void UpdateLineStatus(string lineStatusName)
        {
            LineStatusName = lineStatusName;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
