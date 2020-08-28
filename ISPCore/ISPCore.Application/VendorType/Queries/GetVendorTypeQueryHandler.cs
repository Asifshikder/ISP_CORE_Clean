using Dapper;
using ISPCore.Application.VendorType.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.VendorType.Queries
{
    public class GetVendorTypeQueryHandler : IRequestHandler<Queries.GetVendorType, VendorTypeVM>
    {
        public GetVendorTypeQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<VendorTypeVM> Handle(Queries.GetVendorType request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetVendorTypeById({request.VendorTypeId})";
            var query = $"SELECT * from VendorType where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<VendorTypeVM>(query);
            return data;
        }
    }
}
