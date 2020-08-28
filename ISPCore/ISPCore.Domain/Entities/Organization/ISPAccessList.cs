using ISPCore.Domain.Entities;
using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISPCore.Domain.Entities
{
    public class ISPAccessList : BaseEntity, IHasId<int>, IAggregateRoot
    {
        //public int ISPAccessListID { get; set; }
        public int Id { get; private set; }
        public string AccessName { get; set; }
        public int AccessValue { get; set; }
        public bool IsGranted { get; set; }

        public int Status { get; private set; }

        public ISPAccessList() { }

        public ISPAccessList(string accessName,int accessValue, bool isGranted)
        {
            AccessName = accessName;
            AccessValue = accessValue;
            IsGranted = isGranted;

        }

        public void UpdateISPAccessList(string accessName, int accessValue, bool isGranted)
        {
            AccessName = accessName;
            AccessValue = accessValue;
            IsGranted = isGranted;

        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}