using Dapper;
using ISPCore.Application.CableType.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.CableType.Queries
{
    public class GetCableTypeListQueryHandler : IRequestHandler<Queries.GetCableTypeList, List<CableTypeVM>>
    {
        public GetCableTypeListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<CableTypeVM>> Handle(Queries.GetCableTypeList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, CableTypeName"+"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<CableTypeVM>(query);
            return data.ToList();
        }
    }
}
