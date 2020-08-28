using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ISPAccessList.Queries.Models
{
    public class ISPAccessListVM
    {
        public int Id { get; set; }
        public string AccessName { get; set; }
        public int AccessValue { get; set; }
        public bool IsGranted { get; set; }

    }
}
