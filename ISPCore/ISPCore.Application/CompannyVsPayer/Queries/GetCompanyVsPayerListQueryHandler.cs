using Dapper;
using ISPCore.Application.CompanyVsPayer.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.CompanyVsPayer.Queries
{
    public class GetCompanyVsPayerListQueryHandler : IRequestHandler<Queries.GetCompanyVsPayerList, List<CompanyVsPayerVM>>
    {
        public GetCompanyVsPayerListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<CompanyVsPayerVM>> Handle(Queries.GetCompanyVsPayerList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, CompanyVsPayerName"+"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<CompanyVsPayerVM>(query);
            return data.ToList();
        }
    }
}
