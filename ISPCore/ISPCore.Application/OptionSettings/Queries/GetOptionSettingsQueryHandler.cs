using Dapper;
using ISPCore.Application.OptionSettings.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.OptionSettings.Queries
{
    public class GetOptionSettingsQueryHandler : IRequestHandler<Queries.GetOptionSettings, OptionSettingsVM>
    {
        public GetOptionSettingsQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<OptionSettingsVM> Handle(Queries.GetOptionSettings request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetOptionSettingsById({request.OptionSettingsId})";
            var query = $"SELECT * from OptionSettings where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<OptionSettingsVM>(query);
            return data;
        }
    }
}
