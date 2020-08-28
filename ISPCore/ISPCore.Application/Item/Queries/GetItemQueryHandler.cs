using Dapper;
using ISPCore.Application.Item.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Item.Queries
{
    public class GetItemQueryHandler : IRequestHandler<Queries.GetItem, ItemVM>
    {
        public GetItemQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<ItemVM> Handle(Queries.GetItem request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetItemById({request.ItemId})";
            var query = $"SELECT * from Item where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<ItemVM>(query);
            return data;
        }
    }
}
