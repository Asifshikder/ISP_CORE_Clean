using Dapper;
using ISPCore.Application.Departement.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Departement.Queries
{
    public class GetDepartementListQueryHandler : IRequestHandler<Queries.GetDepartementList, List<DepartementVM>>
    {
        public GetDepartementListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<DepartementVM>> Handle(Queries.GetDepartementList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, DepartementName"+"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<DepartementVM>(query);
            return data.ToList();
        }
    }
}
