using Dapper;
using ISPCore.Application.ProductStatus.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ProductStatus.Queries
{
    public class GetProductStatusListQueryHandler : IRequestHandler<Queries.GetProductStatusList, List<ProductStatusVM>>
    {
        public GetProductStatusListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<ProductStatusVM>> Handle(Queries.GetProductStatusList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, ProductStatusName"+"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<ProductStatusVM>(query);
            return data.ToList();
        }
    }
}
