using Dapper;
using ISPCore.Application.Company.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Company.Queries
{
    public class GetCompanyListQueryHandler : IRequestHandler<Queries.GetCompanyList, List<CompanyVM>>
    {
        public GetCompanyListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<CompanyVM>> Handle(Queries.GetCompanyList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, CompanyName,CompanyEmail,CompanyAddress,ContactPerson,Phone,CompanyLogo,CompanyLogoPath" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<CompanyVM>(query);
            return data.ToList();
        }
    }
}
