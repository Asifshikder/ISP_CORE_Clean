using Dapper;
using ISPCore.Application.Package.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Package.Queries
{
    public class GetPackageQueryHandler : IRequestHandler<Queries.GetPackage, PackageVM>
    {
        public GetPackageQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<PackageVM> Handle(Queries.GetPackage request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetPackageById({request.PackageId})";
            var query = $"SELECT * from Package where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<PackageVM>(query);
            return data;
        }
    }
}
