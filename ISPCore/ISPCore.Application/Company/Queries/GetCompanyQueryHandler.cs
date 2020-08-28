using Dapper;
using ISPCore.Application.Company.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Company.Queries
{
    public class GetCompanyQueryHandler : IRequestHandler<Queries.GetCompany, CompanyVM>
    {
        public GetCompanyQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<CompanyVM> Handle(Queries.GetCompany request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetCompanyById({request.CompanyId})";
            var query = $"SELECT * from Company where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<CompanyVM>(query);
            return data;
        }
    }
}
