using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.VendorType.Command
{
    public static class Commands
    {
        public static class VendorType
        {
            public class Create : IRequest<VendorTypeCommandVM>
            {
                public string VendorTypeName { get; set; }
            }

            public class Update : IRequest<VendorTypeCommandVM>
            {
                public int Id { get; set; }
                public string VendorTypeName { get; set; }
            }

            public class MarkAsDelete : IRequest<VendorTypeCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
