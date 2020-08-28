using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class FormNameForAuth : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public string FormName { get; set; }
        public bool IsGranted { get; set; }
        public string FormID { get; set; }
        public string Text { get; set; }
        public bool @Checked { get; set; }

        public int Status { get; set; }

        public virtual List<ActionNameAuthentication> children { get; set; }


        public FormNameForAuth() { }

        public FormNameForAuth(string formName,bool isGranted,string id,string text,bool @checked)
        {
            FormName = formName;
            IsGranted = isGranted;
            FormID = id;
            Text = text;
            @Checked = @checked;
        }

        public void UpdateFormNameForAuth(string formName, bool isGranted, string id, string text, bool @checked)
        {
            FormName = formName;
            IsGranted = isGranted;
            FormID = id;
            Text = text;
            @Checked = @checked;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
