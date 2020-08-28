using Dapper;
using ISPCore.Application.SMS.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.SMS.Queries
{
    public class GetSMSQueryHandler : IRequestHandler<Queries.GetSMS, SMSVM>
    {
        public GetSMSQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<SMSVM> Handle(Queries.GetSMS request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetSMSById({request.SMSId})";
            var query = $"SELECT * from SMS where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<SMSVM>(query);
            return data;
        }
    }
}
