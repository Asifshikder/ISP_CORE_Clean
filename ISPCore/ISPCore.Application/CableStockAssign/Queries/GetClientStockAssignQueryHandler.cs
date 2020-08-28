using Dapper;
using ISPCore.Application.ClientStockAssign.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ClientStockAssign.Queries
{
    public class GetClientStockAssignQueryHandler : IRequestHandler<Queries.GetClientStockAssign, ClientStockAssignVM>
    {
        public GetClientStockAssignQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<ClientStockAssignVM> Handle(Queries.GetClientStockAssign request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetClientStockAssignById({request.ClientStockAssignId})";
            var query = $"SELECT * from ClientStockAssign where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<ClientStockAssignVM>(query);
            return data;
        }
    }
}
