using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ClientStockAssign.Command
{
    public static class Commands
    {
        public static class ClientStockAssign
        {
            public class Create : IRequest<ClientStockAssignCommandVM>
            {
                public int StockDetailsID { get; set; }
                public int EmployeeID { get; set; }
            }

            public class Update : IRequest<ClientStockAssignCommandVM>
            {
                public int Id { get; set; }
                public int StockDetailsID { get; set; }
                public int EmployeeID { get; set; }
            }

            public class MarkAsDelete : IRequest<ClientStockAssignCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
