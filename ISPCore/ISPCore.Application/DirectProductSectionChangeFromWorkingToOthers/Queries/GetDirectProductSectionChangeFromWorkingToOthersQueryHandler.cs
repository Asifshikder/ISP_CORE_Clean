using Dapper;
using ISPCore.Application.DirectProductSectionChangeFromWorkingToOthers.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.DirectProductSectionChangeFromWorkingToOthers.Queries
{
    public class GetDirectProductSectionChangeFromWorkingToOthersQueryHandler : IRequestHandler<Queries.GetDirectProductSectionChangeFromWorkingToOthers, DirectProductSectionChangeFromWorkingToOthersVM>
    {
        public GetDirectProductSectionChangeFromWorkingToOthersQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<DirectProductSectionChangeFromWorkingToOthersVM> Handle(Queries.GetDirectProductSectionChangeFromWorkingToOthers request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetDirectProductSectionChangeFromWorkingToOthersById({request.DirectProductSectionChangeFromWorkingToOthersId})";
            var query = $"SELECT * from DirectProductSectionChangeFromWorkingToOthers where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<DirectProductSectionChangeFromWorkingToOthersVM>(query);
            return data;
        }
    }
}
