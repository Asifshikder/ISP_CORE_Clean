using ISPCore.Application.MacResellerVSUserPaymentDeductionDetails.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.MacResellerVSUserPaymentDeductionDetails.Queries
{
    public static class Queries
    {
        public class GetMacResellerVSUserPaymentDeductionDetailsList : IRequest<List<MacResellerVSUserPaymentDeductionDetailsVM>>
        {
        }
        public class GetMacResellerVSUserPaymentDeductionDetails : IRequest<MacResellerVSUserPaymentDeductionDetailsVM>
        {
            public int Id { get; set; }
        }
    }
}
