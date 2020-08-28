using Dapper;
using ISPCore.Application.Section.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Section.Queries
{
    public class GetSectionQueryHandler : IRequestHandler<Queries.GetSection, SectionVM>
    {
        public GetSectionQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<SectionVM> Handle(Queries.GetSection request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetSectionById({request.SectionId})";
            var query = $"SELECT * from Section where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<SectionVM>(query);
            return data;
        }
    }
}
