using Dapper;
using ISPCore.Application.Departement.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Departement.Queries
{
    public class GetDepartementQueryHandler : IRequestHandler<Queries.GetDepartement, DepartementVM>
    {
        public GetDepartementQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<DepartementVM> Handle(Queries.GetDepartement request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetDepartementById({request.DepartementId})";
            var query = $"SELECT * from Department where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<DepartementVM>(query);
            return data;
        }
    }
}
