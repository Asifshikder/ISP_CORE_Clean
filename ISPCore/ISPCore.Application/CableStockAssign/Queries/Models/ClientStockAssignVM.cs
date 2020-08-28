using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ClientStockAssign.Queries.Models
{
    public class ClientStockAssignVM
    {
        public int Id { get; set; }
        public int StockDetailsID { get; set; }
        public int EmployeeID { get; set; }
    }
}
