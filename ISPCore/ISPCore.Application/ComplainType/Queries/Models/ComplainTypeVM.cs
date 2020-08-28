using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ComplainType.Queries.Models
{
    public class ComplainTypeVM
    {
        public int Id { get; set; } 
        public string ComplainTypeName { get; set; }
        public bool ShowMessageBox { get; set; }
    }
}
