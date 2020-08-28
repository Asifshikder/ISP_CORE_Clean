using Dapper;
using ISPCore.Application.ISPAccessList.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ISPAccessList.Queries
{
    public class GetISPAccessListListQueryHandler : IRequestHandler<Queries.GetISPAccessListList, List<ISPAccessListVM>>
    {
        public GetISPAccessListListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<ISPAccessListVM>> Handle(Queries.GetISPAccessListList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, AccessName,AccessValue,IsGranted" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<ISPAccessListVM>(query);
            return data.ToList();
        }
    }
}
