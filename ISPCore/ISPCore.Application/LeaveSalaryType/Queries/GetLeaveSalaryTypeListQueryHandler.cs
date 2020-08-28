using Dapper;
using ISPCore.Application.LeaveSalaryType.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.LeaveSalaryType.Queries
{
    public class GetLeaveSalaryTypeListQueryHandler : IRequestHandler<Queries.GetLeaveSalaryTypeList, List<LeaveSalaryTypeVM>>
    {
        public GetLeaveSalaryTypeListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<LeaveSalaryTypeVM>> Handle(Queries.GetLeaveSalaryTypeList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, LeaveSalaryTypeName,Percentage" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<LeaveSalaryTypeVM>(query);
            return data.ToList();
        }
    }
}
