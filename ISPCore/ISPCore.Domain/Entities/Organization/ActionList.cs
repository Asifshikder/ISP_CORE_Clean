using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class ActionList : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public int FormID { get; set; }
        public virtual Form Form { get; set; }
        public string ActionName { get; set; }
        public string ActionValue { get; set; }
        public string ActionDescription { get; set; }

        public int Status { get; private set; }

        public ActionList() { }

        public ActionList(int formID, string actionName, string actionValue, string actionDescription)
        {
            FormID = formID;
            ActionName = actionName;
            ActionValue = actionValue;
            ActionDescription = actionDescription;
        }

        public void UpdateActionList(int formID, string actionName, string actionValue, string actionDescription)
        {
            FormID = formID;
            ActionName = actionName;
            ActionValue = actionValue;
            ActionDescription = actionDescription;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
