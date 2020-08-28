using Dapper;
using ISPCore.Application.Reseller.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Reseller.Queries
{
    public class GetResellerQueryHandler : IRequestHandler<Queries.GetReseller, ResellerVM>
    {
        public GetResellerQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<ResellerVM> Handle(Queries.GetReseller request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetResellerById({request.ResellerId})";
            var query = $"SELECT * from Reseller where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<ResellerVM>(query);
            return data;
        }
    }
}
