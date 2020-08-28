using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class ComplainType : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public string ComplainTypeName { get; private set; }
        public bool ShowMessageBox { get; set; }
        public int Status { get; private set; }


        public ComplainType() { }

        public ComplainType(string complainTypeName,bool showMessageBox)
        {
            ComplainTypeName = complainTypeName;
            ShowMessageBox = showMessageBox;
        }

        public void UpdateComplainType(string complainTypeName, bool showMessageBox)
        {
            ComplainTypeName = complainTypeName;
            ShowMessageBox = showMessageBox;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
