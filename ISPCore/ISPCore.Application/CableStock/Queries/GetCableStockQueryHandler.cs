using Dapper;
using ISPCore.Application.CableStock.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.CableStock.Queries
{
    public class GetCableStockQueryHandler : IRequestHandler<Queries.GetCableStock, CableStockVM>
    {
        public GetCableStockQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<CableStockVM> Handle(Queries.GetCableStock request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetCableStockById({request.CableStockId})";
            var query = $"SELECT * from CableStock where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<CableStockVM>(query);
            return data;
        }
    }
}
