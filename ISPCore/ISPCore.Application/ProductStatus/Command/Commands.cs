using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ProductStatus.Command
{
    public static class Commands
    {
        public static class ProductStatus
        {
            public class Create : IRequest<ProductStatusCommandVM>
            {
                public string ProductStatusName { get; set; }
            }

            public class Update : IRequest<ProductStatusCommandVM>
            {
                public int Id { get; set; }
                public string ProductStatusName { get; set; }
            }

            public class MarkAsDelete : IRequest<ProductStatusCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
