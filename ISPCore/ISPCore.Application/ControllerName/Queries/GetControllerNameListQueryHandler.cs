using Dapper;
using ISPCore.Application.ControllerName.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ControllerName.Queries
{
    public class GetControllerNameListQueryHandler : IRequestHandler<Queries.GetControllerNameList, List<ControllerNameVM>>
    {
        public GetControllerNameListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<ControllerNameVM>> Handle(Queries.GetControllerNameList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, ControllerNames,ControllerValue" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<ControllerNameVM>(query);
            return data.ToList();
        }
    }
}
