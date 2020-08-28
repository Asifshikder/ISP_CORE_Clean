using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
   public class ControllerName : BaseEntity, IHasId<int>, IAggregateRoot
    {
        //public int ControllerID { get; set; }
        public int Id { get; private set; }
        public string ControllerNames { get; set; }
        public string ControllerValue { get; set; }

        public int Status { get; private set; }

        public ControllerName() { }

        public ControllerName(string controllerNames, string controllerValue)
        {
            ControllerNames = controllerNames;
            ControllerValue = controllerValue;
        }

        public void UpdateControllerName(string controllerNames, string controllerValue)
        {
            ControllerNames = controllerNames;
            ControllerValue = controllerValue;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
