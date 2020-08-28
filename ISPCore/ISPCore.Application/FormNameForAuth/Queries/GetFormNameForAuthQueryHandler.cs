using Dapper;
using ISPCore.Application.FormNameForAuth.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.FormNameForAuth.Queries
{
    public class GetFormNameForAuthQueryHandler : IRequestHandler<Queries.GetFormNameForAuth, FormNameForAuthVM>
    {
        public GetFormNameForAuthQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<FormNameForAuthVM> Handle(Queries.GetFormNameForAuth request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetFormNameForAuthById({request.FormNameForAuthId})";
            var query = $"SELECT * from FormNameForAuth where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<FormNameForAuthVM>(query);
            return data;
        }
    }
}
