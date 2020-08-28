using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.LeaveSalaryType.Queries.Models
{
    public class LeaveSalaryTypeVM
    {
        public int Id { get; set; } 
        public string LeaveSalaryTypeName { get; set; } 
        public decimal Percentage { get; set; } 

    }
}
