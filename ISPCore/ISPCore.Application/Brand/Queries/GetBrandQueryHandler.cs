using Dapper;
using ISPCore.Application.Brand.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Brand.Queries
{
    public class GetBrandQueryHandler : IRequestHandler<Queries.GetBrand, BrandVM>
    {
        public GetBrandQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<BrandVM> Handle(Queries.GetBrand request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetBrandById({request.BrandId})";
            var query = $"SELECT * from Brand where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<BrandVM>(query);
            return data;
        }
    }
}
