using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ClientCableDistribution.Queries.Models
{
    public class ClientCableDistributionVM
    {
        public int Id { get; set; }
        public int CableQuantity { get; set; }
        public int? EmployeeID { get; set; }
        public int? ClientID { get; set; }
        public int? AssignEmployee { get; set; }
    }
}
