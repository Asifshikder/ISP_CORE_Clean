using Dapper;
using ISPCore.Application.ComplainType.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ComplainType.Queries
{
    public class GetComplainTypeQueryHandler : IRequestHandler<Queries.GetComplainType, ComplainTypeVM>
    {
        public GetComplainTypeQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<ComplainTypeVM> Handle(Queries.GetComplainType request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetComplainTypeById({request.ComplainTypeId})";
            var query = $"SELECT * from ComplainType where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<ComplainTypeVM>(query);
            return data;
        }
    }
}
