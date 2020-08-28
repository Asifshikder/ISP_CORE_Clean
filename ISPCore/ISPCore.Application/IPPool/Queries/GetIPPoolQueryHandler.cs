using Dapper;
using ISPCore.Application.IPPool.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.IPPool.Queries
{
    public class GetIPPoolQueryHandler : IRequestHandler<Queries.GetIPPool, IPPoolVM>
    {
        public GetIPPoolQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<IPPoolVM> Handle(Queries.GetIPPool request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetIPPoolById({request.IPPoolId})";
            var query = $"SELECT * from IPPool where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<IPPoolVM>(query);
            return data;
        }
    }
}
