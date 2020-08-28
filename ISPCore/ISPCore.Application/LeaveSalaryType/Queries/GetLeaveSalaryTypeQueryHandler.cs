using Dapper;
using ISPCore.Application.LeaveSalaryType.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.LeaveSalaryType.Queries
{
    public class GetLeaveSalaryTypeQueryHandler : IRequestHandler<Queries.GetLeaveSalaryType, LeaveSalaryTypeVM>
    {
        public GetLeaveSalaryTypeQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<LeaveSalaryTypeVM> Handle(Queries.GetLeaveSalaryType request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetLeaveSalaryTypeById({request.LeaveSalaryTypeId})";
            var query = $"SELECT * from LeaveSalaryType where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<LeaveSalaryTypeVM>(query);
            return data;
        }
    }
}
