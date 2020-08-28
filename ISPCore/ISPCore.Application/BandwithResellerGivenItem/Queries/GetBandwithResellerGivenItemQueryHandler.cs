using Dapper;
using ISPCore.Application.BandwithResellerGivenItem.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.BandwithResellerGivenItem.Queries
{
    public class GetBandwithResellerGivenItemQueryHandler : IRequestHandler<Queries.GetBandwithResellerGivenItem, BandwithResellerGivenItemVM>
    {
        public GetBandwithResellerGivenItemQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<BandwithResellerGivenItemVM> Handle(Queries.GetBandwithResellerGivenItem request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetBandwithResellerGivenItemById({request.BandwithResellerGivenItemId})";
            var query = $"SELECT * from BandwithResellerGivenItem where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<BandwithResellerGivenItemVM>(query);
            return data;
        }
    }
}
