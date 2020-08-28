using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Brand.Command
{
    public static class Commands
    {
        public static class Brand
        {
            public class Create : IRequest<BrandCommandVM>
            {
                public string BrandName { get; set; }
            }

            public class Update : IRequest<BrandCommandVM>
            {
                public int Id { get; set; }
                public string BrandName { get; set; }
            }

            public class MarkAsDelete : IRequest<BrandCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
