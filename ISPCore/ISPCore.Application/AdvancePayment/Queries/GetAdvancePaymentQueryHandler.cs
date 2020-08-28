using Dapper;
using ISPCore.Application.AdvancePayment.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.AdvancePayment.Queries
{
    public class GetAdvancePaymentQueryHandler : IRequestHandler<Queries.GetAdvancePayment, AdvancePaymentVM>
    {
        public GetAdvancePaymentQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<AdvancePaymentVM> Handle(Queries.GetAdvancePayment request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetAdvancePaymentById({request.AdvancePaymentId})";
            var query = $"SELECT * from AdvancePayment where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<AdvancePaymentVM>(query);
            return data;
        }
    }
}
