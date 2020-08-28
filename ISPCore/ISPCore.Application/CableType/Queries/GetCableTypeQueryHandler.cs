using Dapper;
using ISPCore.Application.CableType.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.CableType.Queries
{
    public class GetCableTypeQueryHandler : IRequestHandler<Queries.GetCableType, CableTypeVM>
    {
        public GetCableTypeQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<CableTypeVM> Handle(Queries.GetCableType request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetCableTypeById({request.CableTypeId})";
            var query = $"SELECT * from CableType where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<CableTypeVM>(query);
            return data;
        }
    }
}
