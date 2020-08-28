using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.GivenPaymentType.Command
{
    public static class Commands
    {
        public static class GivenPaymentType
        {
            public class Create : IRequest<GivenPaymentTypeCommandVM>
            {
                public string GivenPaymentTypeName { get; set; }
            }

            public class Update : IRequest<GivenPaymentTypeCommandVM>
            {
                public int Id { get; set; }
                public string GivenPaymentTypeName { get; set; }
            }

            public class MarkAsDelete : IRequest<GivenPaymentTypeCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
