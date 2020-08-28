using Dapper;
using ISPCore.Application.ProfilePercentageFields.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ProfilePercentageFields.Queries
{
    public class GetProfilePercentageFieldsListQueryHandler : IRequestHandler<Queries.GetProfilePercentageFieldsList, List<ProfilePercentageFieldsVM>>
    {
        public GetProfilePercentageFieldsListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<ProfilePercentageFieldsVM>> Handle(Queries.GetProfilePercentageFieldsList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, FieldsName,TableName,MappingField" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<ProfilePercentageFieldsVM>(query);
            return data.ToList();
        }
    }
}
