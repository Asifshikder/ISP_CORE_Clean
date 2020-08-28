using Dapper;
using ISPCore.Application.Section.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Section.Queries
{
    public class GetSectionListQueryHandler : IRequestHandler<Queries.GetSectionList, List<SectionVM>>
    {
        public GetSectionListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<SectionVM>> Handle(Queries.GetSectionList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, SectionName"+"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<SectionVM>(query);
            return data.ToList();
        }
    }
}
