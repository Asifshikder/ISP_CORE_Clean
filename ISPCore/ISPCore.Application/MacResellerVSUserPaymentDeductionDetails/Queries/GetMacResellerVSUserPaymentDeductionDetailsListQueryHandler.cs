using Dapper;
using ISPCore.Application.MacResellerVSUserPaymentDeductionDetails.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.MacResellerVSUserPaymentDeductionDetails.Queries
{
    public class GetMacResellerVSUserPaymentDeductionDetailsListQueryHandler : IRequestHandler<Queries.GetMacResellerVSUserPaymentDeductionDetailsList, List<MacResellerVSUserPaymentDeductionDetailsVM>>
    {
        public GetMacResellerVSUserPaymentDeductionDetailsListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<MacResellerVSUserPaymentDeductionDetailsVM>> Handle(Queries.GetMacResellerVSUserPaymentDeductionDetailsList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, ClientDetailsID, ResellerID, PaymentYear, PaymentMonth, PaymentAmount, PaymentTime, PaymentTimeResellerBalance" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<MacResellerVSUserPaymentDeductionDetailsVM>(query);
            return data.ToList();
        }
    }
}
