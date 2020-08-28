using Dapper;
using ISPCore.Application.SMSSenderIDPass.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.SMSSenderIDPass.Queries
{
    public class GetSMSSenderIDPassQueryHandler : IRequestHandler<Queries.GetSMSSenderIDPass, SMSSenderIDPassVM>
    {
        public GetSMSSenderIDPassQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<SMSSenderIDPassVM> Handle(Queries.GetSMSSenderIDPass request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetSMSSenderIDPassById({request.SMSSenderIDPassId})";
            var query = $"SELECT * from SMSSenderIDPass where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<SMSSenderIDPassVM>(query);
            return data;
        }
    }
}
