using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ActionList.Queries.Models
{
    public class ActionListVM
    {
        public int Id { get; set; }
        public int FormID { get; set; }
        public string ActionName { get; set; }
        public string ActionValue { get; set; }
        public string ActionDescription { get; set; }
    }
}
