using Dapper;
using ISPCore.Application.DistributionReason.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.DistributionReason.Queries
{
    public class GetDistributionReasonQueryHandler : IRequestHandler<Queries.GetDistributionReason, DistributionReasonVM>
    {
        public GetDistributionReasonQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<DistributionReasonVM> Handle(Queries.GetDistributionReason request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetDistributionReasonById({request.DistributionReasonId})";
            var query = $"SELECT * from DistributionReason where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<DistributionReasonVM>(query);
            return data;
        }
    }
}
