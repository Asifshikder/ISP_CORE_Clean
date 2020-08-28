using Dapper;
using ISPCore.Application.Brand.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Brand.Queries
{
    public class GetBrandListQueryHandler : IRequestHandler<Queries.GetBrandList, List<BrandVM>>
    {
        public GetBrandListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<BrandVM>> Handle(Queries.GetBrandList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, BrandName"+"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<BrandVM>(query);
            return data.ToList();
        }
    }
}
