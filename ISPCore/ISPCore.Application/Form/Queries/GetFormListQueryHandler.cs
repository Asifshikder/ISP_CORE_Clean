using Dapper;
using ISPCore.Application.Form.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Form.Queries
{
    public class GetFormListQueryHandler : IRequestHandler<Queries.GetFormList, List<FormVM>>
    {
        public GetFormListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<FormVM>> Handle(Queries.GetFormList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, FormName,ControllerNameID,FormValue,FormDescription,FormLocation" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<FormVM>(query);
            return data.ToList();
        }
    }
}
