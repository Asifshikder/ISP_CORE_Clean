using Dapper;
using ISPCore.Application.ResellerBillingCycle.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ResellerBillingCycle.Queries
{
    public class GetResellerBillingCycleQueryHandler : IRequestHandler<Queries.GetResellerBillingCycle, ResellerBillingCycleVM>
    {
        public GetResellerBillingCycleQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<ResellerBillingCycleVM> Handle(Queries.GetResellerBillingCycle request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetResellerBillingCycleById({request.ResellerBillingCycleId})";
            var query = $"SELECT * from ResellerBillingCycle where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<ResellerBillingCycleVM>(query);
            return data;
        }
    }
}
