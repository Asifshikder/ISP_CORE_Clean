using Dapper;
using ISPCore.Application.Item.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Item.Queries
{
    public class GetItemListQueryHandler : IRequestHandler<Queries.GetItemList, List<ItemVM>>
    {
        public GetItemListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<ItemVM>> Handle(Queries.GetItemList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, ItemName,ItemFor,ItemCode" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<ItemVM>(query);
            return data.ToList();
        }
    }
}
