using Dapper;
using ISPCore.Application.SMS.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.SMS.Queries
{
    public class GetSMSListQueryHandler : IRequestHandler<Queries.GetSMSList, List<SMSVM>>
    {
        public GetSMSListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<SMSVM>> Handle(Queries.GetSMSList request, CancellationToken cancellationToken)
        {
            var query = $"select Id,SMSTitle,SendMessageText,SMSCode,.Sender,SMSStatus,SMSCounter" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<SMSVM>(query);
            return data.ToList();
        }
    }
}
