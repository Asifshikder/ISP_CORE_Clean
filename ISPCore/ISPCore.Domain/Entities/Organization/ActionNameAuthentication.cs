using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class ActionNameAuthentication : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public string ActionName { get; set; }
        public bool IsGranted { get; set; }
        public string ActionID { get; set; }
        public string Text { get; set; }
        public bool @Checked { get; set; }
        public int Status { get; private set; }


        public ActionNameAuthentication() { }

        public ActionNameAuthentication(string actionName, bool isGranted, string actionID, string text, bool @checked)
        {
            ActionName = actionName;
            IsGranted = isGranted;
            ActionID = actionID;
            Text = text;
            @Checked = @checked;
        }

        public void UpdateActionNameAuthentication(string actionName, bool isGranted, string actionID, string text, bool @checked)
        {
            ActionName = actionName;
            IsGranted = isGranted;
            ActionID = actionID;
            Text = text;
            @Checked = @checked;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
