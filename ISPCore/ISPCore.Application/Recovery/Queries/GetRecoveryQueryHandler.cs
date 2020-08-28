using Dapper;
using ISPCore.Application.Recovery.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Recovery.Queries
{
    public class GetRecoveryQueryHandler : IRequestHandler<Queries.GetRecovery, RecoveryVM>
    {
        public GetRecoveryQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<RecoveryVM> Handle(Queries.GetRecovery request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetRecoveryById({request.RecoveryId})";
            var query = $"SELECT * from Recovery where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<RecoveryVM>(query);
            return data;
        }
    }
}
