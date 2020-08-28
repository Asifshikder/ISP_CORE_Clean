using Dapper;
using ISPCore.Application.DirectProductSectionChangeFromWorkingToOthers.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.DirectProductSectionChangeFromWorkingToOthers.Queries
{
    public class GetDirectProductSectionChangeFromWorkingToOthersListQueryHandler : IRequestHandler<Queries.GetDirectProductSectionChangeFromWorkingToOthersList, List<DirectProductSectionChangeFromWorkingToOthersVM>>
    {
        public GetDirectProductSectionChangeFromWorkingToOthersListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<DirectProductSectionChangeFromWorkingToOthersVM>> Handle(Queries.GetDirectProductSectionChangeFromWorkingToOthersList request, CancellationToken cancellationToken)
        {
            var query = $"select Id,  ClientName, TakenEmployee, StockDetailsID, FromSection, ToSection, WhoChanged, ChangeDateTime" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<DirectProductSectionChangeFromWorkingToOthersVM>(query);
            return data.ToList();
        }
    }
}
