using Dapper;
using ISPCore.Application.Supplier.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Supplier.Queries
{
    public class GetSupplierQueryHandler : IRequestHandler<Queries.GetSupplier, SupplierVM>
    {
        public GetSupplierQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<SupplierVM> Handle(Queries.GetSupplier request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetSupplierById({request.SupplierId})";
            var query = $"SELECT * from Supplier where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<SupplierVM>(query);
            return data;
        }
    }
}
