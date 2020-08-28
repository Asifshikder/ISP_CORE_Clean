using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class ClientCableAssign : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public int CableQuantity { get; set; }
        public int EmployeeID { get; set; }

        public int Status { get; private set; }


        public ClientCableAssign() { }

        public ClientCableAssign(int cableQuantity,int employeeID)
        {
            CableQuantity = cableQuantity;
            EmployeeID = employeeID;
        }

        public void UpdateClientCableAssign(int cableQuantity, int employeeID)
        {
            CableQuantity = cableQuantity;
            EmployeeID = employeeID;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
