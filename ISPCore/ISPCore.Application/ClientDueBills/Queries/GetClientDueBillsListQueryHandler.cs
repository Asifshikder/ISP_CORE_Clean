using Dapper;
using ISPCore.Application.ClientDueBills.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ClientDueBills.Queries
{
    public class GetClientDueBillsListQueryHandler : IRequestHandler<Queries.GetClientDueBillsList, List<ClientDueBillsVM>>
    {
        public GetClientDueBillsListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<ClientDueBillsVM>> Handle(Queries.GetClientDueBillsList request, CancellationToken cancellationToken)
        {
            var query = $"select Id,ClientDetailsID,DueAmount,Year,Month" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<ClientDueBillsVM>(query);
            return data.ToList();
        }
    }
}
