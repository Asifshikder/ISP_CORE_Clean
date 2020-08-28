using Dapper;
using ISPCore.Application.Vendor.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Vendor.Queries
{
    public class GetVendorListQueryHandler : IRequestHandler<Queries.GetVendorList, List<VendorVM>>
    {
        public GetVendorListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<VendorVM>> Handle(Queries.GetVendorList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, request.VendorName,VendorAddress,CompanyName,VendorLogoName,VendorImageOriginal,VendorImagePath,VendorContactPerson,VendorEmail" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<VendorVM>(query);
            return data.ToList();
        }
    }
}
