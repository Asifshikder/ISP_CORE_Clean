using Dapper;
using ISPCore.Application.ActionList.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ActionList.Queries
{
    public class GetActionListQueryHandler : IRequestHandler<Queries.GetActionList, ActionListVM>
    {
        public GetActionListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<ActionListVM> Handle(Queries.GetActionList request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetActionListById({request.ActionListId})";
            var query = $"SELECT * from ActionList where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<ActionListVM>(query);
            return data;
        }
    }
}
