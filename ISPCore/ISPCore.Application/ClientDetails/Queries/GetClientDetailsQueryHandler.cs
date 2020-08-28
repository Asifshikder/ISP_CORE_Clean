using Dapper;
using ISPCore.Application.ClientDetails.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ClientDetails.Queries
{
    public class GetClientDetailsQueryHandler : IRequestHandler<Queries.GetClientDetails, ClientDetailsVM>
    {
        public GetClientDetailsQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<ClientDetailsVM> Handle(Queries.GetClientDetails request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetClientDetailsById({request.ClientDetailsId})";
            var query = $"SELECT * from ClientDetails where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<ClientDetailsVM>(query);
            return data;
        }
    }
}
