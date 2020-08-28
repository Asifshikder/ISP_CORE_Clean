using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class ClientCableDistribution : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public int CableQuantity { get; set; }
        public int? EmployeeID { get; set; }
        public int? ClientID { get; set; }
        public int? AssignEmployee { get; set; }
        public int Status { get; private set; }


        public ClientCableDistribution() { }

        public ClientCableDistribution(int cableQuantity, int? employeeID, int? clientID, int? assignEmployee)
        {
            CableQuantity = cableQuantity;
            EmployeeID = employeeID;
            ClientID = clientID;
            AssignEmployee = assignEmployee;
        }

        public void UpdateClientCableDistribution(int cableQuantity, int? employeeID, int? clientID, int? assignEmployee)
        {
            CableQuantity = cableQuantity;
            EmployeeID = employeeID;
            ClientID = clientID;
            AssignEmployee = assignEmployee;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
