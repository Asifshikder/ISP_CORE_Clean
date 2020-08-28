using Dapper;
using ISPCore.Application.GivenPaymentType.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.GivenPaymentType.Queries
{
    public class GetGivenPaymentTypeListQueryHandler : IRequestHandler<Queries.GetGivenPaymentTypeList, List<GivenPaymentTypeVM>>
    {
        public GetGivenPaymentTypeListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<GivenPaymentTypeVM>> Handle(Queries.GetGivenPaymentTypeList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, GivenPaymentTypeName"+"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<GivenPaymentTypeVM>(query);
            return data.ToList();
        }
    }
}
