using Dapper;
using ISPCore.Application.VendorType.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.VendorType.Queries
{
    public class GetVendorTypeListQueryHandler : IRequestHandler<Queries.GetVendorTypeList, List<VendorTypeVM>>
    {
        public GetVendorTypeListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<VendorTypeVM>> Handle(Queries.GetVendorTypeList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, VendorTypeName"+"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<VendorTypeVM>(query);
            return data.ToList();
        }
    }
}
