using Dapper;
using ISPCore.Application.CompanyVsPayer.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.CompanyVsPayer.Queries
{
    public class GetCompanyVsPayerQueryHandler : IRequestHandler<Queries.GetCompanyVsPayer, CompanyVsPayerVM>
    {
        public GetCompanyVsPayerQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<CompanyVsPayerVM> Handle(Queries.GetCompanyVsPayer request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetCompanyVsPayerById({request.CompanyVsPayerId})";
            var query = $"SELECT * from CompanyVsPayer where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<CompanyVsPayerVM>(query);
            return data;
        }
    }
}
