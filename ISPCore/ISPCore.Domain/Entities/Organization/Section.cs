using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class Section : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public string SectionName { get; private set; }

        public int Status { get; private set; }


        public Section() { }

        public Section(string sectionName)
        {
            SectionName = sectionName;
        }

        public void UpdateSection(string sectionName)
        {
            SectionName = sectionName;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
