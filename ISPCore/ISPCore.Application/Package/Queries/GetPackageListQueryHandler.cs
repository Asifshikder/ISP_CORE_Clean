using Dapper;
using ISPCore.Application.Package.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Package.Queries
{
    public class GetPackageListQueryHandler : IRequestHandler<Queries.GetPackageList, List<PackageVM>>
    {
        public GetPackageListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<PackageVM>> Handle(Queries.GetPackageList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, PackageName,IPPoolID,MikrotikID,LocalAddress,OldPackageName,PackagePrice,BandWith" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<PackageVM>(query);
            return data.ToList();
        }
    }
}
