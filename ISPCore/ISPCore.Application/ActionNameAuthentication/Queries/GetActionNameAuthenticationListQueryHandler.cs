using Dapper;
using ISPCore.Application.ActionNameAuthentication.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ActionNameAuthentication.Queries
{
    public class GetActionNameAuthenticationListQueryHandler : IRequestHandler<Queries.GetActionNameAuthenticationList, List<ActionNameAuthenticationVM>>
    {
        public GetActionNameAuthenticationListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<ActionNameAuthenticationVM>> Handle(Queries.GetActionNameAuthenticationList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, ActionName,IsGranted,ID,Text,@Checked" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<ActionNameAuthenticationVM>(query);
            return data.ToList();
        }
    }
}
