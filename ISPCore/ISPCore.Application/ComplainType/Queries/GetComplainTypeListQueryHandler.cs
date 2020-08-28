using Dapper;
using ISPCore.Application.ComplainType.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ComplainType.Queries
{
    public class GetComplainTypeListQueryHandler : IRequestHandler<Queries.GetComplainTypeList, List<ComplainTypeVM>>
    {
        public GetComplainTypeListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<ComplainTypeVM>> Handle(Queries.GetComplainTypeList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, ComplainTypeName,ShowMessageBox" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<ComplainTypeVM>(query);
            return data.ToList();
        }
    }
}
