using Dapper;
using ISPCore.Application.Supplier.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Supplier.Queries
{
    public class GetSupplierListQueryHandler : IRequestHandler<Queries.GetSupplierList, List<SupplierVM>>
    {
        public GetSupplierListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<SupplierVM>> Handle(Queries.GetSupplierList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, SupplierName,SupplierAddress" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<SupplierVM>(query);
            return data.ToList();
        }
    }
}
