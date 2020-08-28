using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ClientDueBills.Queries.Models
{
    public class ClientDueBillsVM
    {
        public int Id { get; set; }
        public int ClientDetailsID { get; set; }
        public double DueAmount { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
    }
}
