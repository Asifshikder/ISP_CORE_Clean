using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Supplier.Command
{
    public static class Commands
    {
        public static class Supplier
        {
            public class Create : IRequest<SupplierCommandVM>
            {
                
                public string SupplierName { get; set; }
                public string SupplierAddress { get; set; }
            }

            public class Update : IRequest<SupplierCommandVM>
            {
                public int Id { get; set; }
                public string SupplierName { get; set; }
                public string SupplierAddress { get; set; }
            }

            public class MarkAsDelete : IRequest<SupplierCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
