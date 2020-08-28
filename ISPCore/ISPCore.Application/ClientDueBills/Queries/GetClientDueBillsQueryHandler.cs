using Dapper;
using ISPCore.Application.ClientDueBills.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ClientDueBills.Queries
{
    public class GetClientDueBillsQueryHandler : IRequestHandler<Queries.GetClientDueBills, ClientDueBillsVM>
    {
        public GetClientDueBillsQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<ClientDueBillsVM> Handle(Queries.GetClientDueBills request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetClientDueBillsById({request.ClientDueBillsId})";
            var query = $"SELECT * from ClientDueBills where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<ClientDueBillsVM>(query);
            return data;
        }
    }
}
