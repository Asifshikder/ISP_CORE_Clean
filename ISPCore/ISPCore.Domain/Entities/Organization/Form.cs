using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class Form : BaseEntity, IHasId<int>, IAggregateRoot
    {
        //public int ControllerID { get; set; }
        public int Id { get; private set; }
        public int ControllerNameID { get; set; }
        public virtual ControllerName ControllerName { get; set; }
        public string FormName { get; set; }
        public string FormValue { get; set; }
        public string FormDescription { get; set; }
        public string FormLocation { get; set; }

        public int Status { get; private set; }

        public Form() { }

        public Form(string formName, int controllerNameID,string formValue, string formDescription,string formLocation)
        {
            FormName = formName;
            ControllerNameID = controllerNameID;
            FormValue = formName;
            FormDescription = formDescription;
            FormLocation = formLocation;
        }

        public void UpdateForm(string formName, int controllerNameID, string formValue, string formDescription, string formLocation)
        {
            FormName = formName;
            ControllerNameID = controllerNameID;
            FormValue = formName;
            FormDescription = formDescription;
            FormLocation = formLocation;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
