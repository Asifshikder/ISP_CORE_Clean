using Dapper;
using ISPCore.Application.ProductStatus.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ProductStatus.Queries
{
    public class GetProductStatusQueryHandler : IRequestHandler<Queries.GetProductStatus, ProductStatusVM>
    {
        public GetProductStatusQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<ProductStatusVM> Handle(Queries.GetProductStatus request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetProductStatusById({request.ProductStatusId})";
            var query = $"SELECT * from ProductStatus where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<ProductStatusVM>(query);
            return data;
        }
    }
}
