using Dapper;
using ISPCore.Application.ClientStockAssign.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ClientStockAssign.Queries
{
    public class GetClientStockAssignListQueryHandler : IRequestHandler<Queries.GetClientStockAssignList, List<ClientStockAssignVM>>
    {
        public GetClientStockAssignListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<ClientStockAssignVM>> Handle(Queries.GetClientStockAssignList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, StockDetailsID,EmployeeID" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<ClientStockAssignVM>(query);
            return data.ToList();
        }
    }
}
