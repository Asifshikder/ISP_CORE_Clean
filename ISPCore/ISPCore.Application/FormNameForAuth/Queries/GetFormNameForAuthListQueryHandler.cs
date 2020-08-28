using Dapper;
using ISPCore.Application.FormNameForAuth.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.FormNameForAuth.Queries
{
    public class GetFormNameForAuthListQueryHandler : IRequestHandler<Queries.GetFormNameForAuthList, List<FormNameForAuthVM>>
    {
        public GetFormNameForAuthListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
      

        private readonly DbConnection _connection;

        public async Task<List<FormNameForAuthVM>> Handle(Queries.GetFormNameForAuthList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, FormName,IsGranted,ID,Text,@Checked" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<FormNameForAuthVM>(query);
            return data.ToList();
        }
    }
}
