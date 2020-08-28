using Dapper;
using ISPCore.Application.Form.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Form.Queries
{
    public class GetFormQueryHandler : IRequestHandler<Queries.GetForm, FormVM>
    {
        public GetFormQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<FormVM> Handle(Queries.GetForm request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetFormById({request.FormId})";
            var query = $"SELECT * from Form where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<FormVM>(query);
            return data;
        }
    }
}
