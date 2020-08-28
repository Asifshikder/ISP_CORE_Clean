using Dapper;
using ISPCore.Application.SMSSenderIDPass.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.SMSSenderIDPass.Queries
{
    public class GetSMSSenderIDPassListQueryHandler : IRequestHandler<Queries.GetSMSSenderIDPassList, List<SMSSenderIDPassVM>>
    {
        public GetSMSSenderIDPassListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<SMSSenderIDPassVM>> Handle(Queries.GetSMSSenderIDPassList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, SenderID, Pass, Sender, CompanyName, HelpLine" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<SMSSenderIDPassVM>(query);
            return data.ToList();
        }
    }
}
