using Dapper;
using ISPCore.Application.Vendor.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Vendor.Queries
{
    public class GetVendorQueryHandler : IRequestHandler<Queries.GetVendor, VendorVM>
    {
        public GetVendorQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<VendorVM> Handle(Queries.GetVendor request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetVendorById({request.VendorId})";
            var query = $"SELECT * from Vendor where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<VendorVM>(query);
            return data;
        }
    }
}
