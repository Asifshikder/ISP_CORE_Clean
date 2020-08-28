using Dapper;
using ISPCore.Application.GivenPaymentType.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.GivenPaymentType.Queries
{
    public class GetGivenPaymentTypeQueryHandler : IRequestHandler<Queries.GetGivenPaymentType, GivenPaymentTypeVM>
    {
        public GetGivenPaymentTypeQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<GivenPaymentTypeVM> Handle(Queries.GetGivenPaymentType request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetGivenPaymentTypeById({request.GivenPaymentTypeId})";
            var query = $"SELECT * from GivenPaymentType where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<GivenPaymentTypeVM>(query);
            return data;
        }
    }
}
