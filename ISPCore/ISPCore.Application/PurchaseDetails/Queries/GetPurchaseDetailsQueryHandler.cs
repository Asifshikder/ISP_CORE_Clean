using Dapper;
using ISPCore.Application.PurchaseDetails.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.PurchaseDetails.Queries
{
    public class GetPurchaseDetailsQueryHandler : IRequestHandler<Queries.GetPurchaseDetails, PurchaseDetailsVM>
    {
        public GetPurchaseDetailsQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<PurchaseDetailsVM> Handle(Queries.GetPurchaseDetails request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetPurchaseDetailsById({request.PurchaseDetailsId})";
            var query = $"SELECT * from PurchaseDetails where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<PurchaseDetailsVM>(query);
            return data;
        }
    }
}
