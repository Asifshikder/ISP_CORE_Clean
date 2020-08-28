using Dapper;
using ISPCore.Application.OptionSettings.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.OptionSettings.Queries
{
    public class GetOptionSettingsListQueryHandler : IRequestHandler<Queries.GetOptionSettingsList, List<OptionSettingsVM>>
    {
        public GetOptionSettingsListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<OptionSettingsVM>> Handle(Queries.GetOptionSettingsList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, OptionSettingsName"+"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<OptionSettingsVM>(query);
            return data.ToList();
        }
    }
}
