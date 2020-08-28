using Dapper;
using ISPCore.Application.ISPAccessList.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ISPAccessList.Queries
{
    public class GetISPAccessListQueryHandler : IRequestHandler<Queries.GetISPAccessList, ISPAccessListVM>
    {
        public GetISPAccessListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<ISPAccessListVM> Handle(Queries.GetISPAccessList request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetISPAccessListById({request.ISPAccessListId})";
            var query = $"SELECT * from ISPAccessList where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<ISPAccessListVM>(query);
            return data;
        }
    }
}
