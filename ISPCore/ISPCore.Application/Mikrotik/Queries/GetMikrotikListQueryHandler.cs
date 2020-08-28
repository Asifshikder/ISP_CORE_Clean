using Dapper;
using ISPCore.Application.Mikrotik.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Mikrotik.Queries
{
    public class GetMikrotikListQueryHandler : IRequestHandler<Queries.GetMikrotikList, List<MikrotikVM>>
    {
        public GetMikrotikListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<MikrotikVM>> Handle(Queries.GetMikrotikList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, MikrotikName,RealIP,MikUserName,MikPassword,APIPort,WebPort" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<MikrotikVM>(query);
            return data.ToList();
        }
    }
}
