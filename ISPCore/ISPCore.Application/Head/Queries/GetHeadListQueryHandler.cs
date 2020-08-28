using Dapper;
using ISPCore.Application.Head.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Head.Queries
{
    public class GetHeadListQueryHandler : IRequestHandler<Queries.GetHeadList, List<HeadVM>>
    {
        public GetHeadListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<HeadVM>> Handle(Queries.GetHeadList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, HeadName,HeadTypeID,ResellerID" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<HeadVM>(query);
            return data.ToList();
        }
    }
}
