using Dapper;
using ISPCore.Application.ActionList.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ActionList.Queries
{
    public class GetActionListListQueryHandler : IRequestHandler<Queries.GetActionListList, List<ActionListVM>>
    {
        public GetActionListListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<ActionListVM>> Handle(Queries.GetActionListList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, FormID,ActionName,ActionValue,ActionDescription" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<ActionListVM>(query);
            return data.ToList();
        }
    }
}
