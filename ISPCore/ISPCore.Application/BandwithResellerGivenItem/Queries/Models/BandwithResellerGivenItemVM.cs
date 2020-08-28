using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.BandwithResellerGivenItem.Queries.Models
{
    public class BandwithResellerGivenItemVM
    {
        public int Id { get; set; } 
        public string ItemName { get; set; }
        public string MeasureUnit { get; set; }
        public string PerUnitCommonPrice { get; set; }
    }
}
