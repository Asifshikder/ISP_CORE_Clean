using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class ClientStockAssign : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public int StockDetailsID { get; set; }
        public int EmployeeID { get; set; }

        public int Status { get; private set; }


        public ClientStockAssign() { }

        public ClientStockAssign(int stockDetailsID, int employeeID)
        {
            StockDetailsID = stockDetailsID;
            EmployeeID = employeeID;
        }

        public void UpdateClientStockAssign(int stockDetailsID, int employeeID)
        {
            StockDetailsID = stockDetailsID;
            EmployeeID = employeeID;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
