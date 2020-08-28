using ISPCore.Application.GivenPaymentType.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.GivenPaymentType.Queries
{
    public static class Queries
    {
        public class GetGivenPaymentTypeList : IRequest<List<GivenPaymentTypeVM>>
        {
        }
        public class GetGivenPaymentType : IRequest<GivenPaymentTypeVM>
        {
            public int Id { get; set; }
        }
    }
}
