using Dapper;
using ISPCore.Application.ProfilePercentageFields.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ProfilePercentageFields.Queries
{
    public class GetProfilePercentageFieldsQueryHandler : IRequestHandler<Queries.GetProfilePercentageFields, ProfilePercentageFieldsVM>
    {
        public GetProfilePercentageFieldsQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<ProfilePercentageFieldsVM> Handle(Queries.GetProfilePercentageFields request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetProfilePercentageFieldsById({request.ProfilePercentageFieldsId})";
            var query = $"SELECT * from ProfilePercentageFields where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<ProfilePercentageFieldsVM>(query);
            return data;
        }
    }
}
