using Dapper;
using ISPCore.Application.MacResellerVSUserPaymentDeductionDetails.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.MacResellerVSUserPaymentDeductionDetails.Queries
{
    public class GetMacResellerVSUserPaymentDeductionDetailsQueryHandler : IRequestHandler<Queries.GetMacResellerVSUserPaymentDeductionDetails, MacResellerVSUserPaymentDeductionDetailsVM>
    {
        public GetMacResellerVSUserPaymentDeductionDetailsQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<MacResellerVSUserPaymentDeductionDetailsVM> Handle(Queries.GetMacResellerVSUserPaymentDeductionDetails request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetMacResellerVSUserPaymentDeductionDetailsById({request.MacResellerVSUserPaymentDeductionDetailsId})";
            var query = $"SELECT * from MacResellerVSUserPaymentDeductionDetails where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<MacResellerVSUserPaymentDeductionDetailsVM>(query);
            return data;
        }
    }
}
