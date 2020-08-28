using Dapper;
using ISPCore.Application.LoginViewModel.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.LoginViewModel.Queries
{
    public class GetLoginViewModelListQueryHandler : IRequestHandler<Queries.GetLoginViewModelList, List<LoginViewModelVM>>
    {
        public GetLoginViewModelListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<LoginViewModelVM>> Handle(Queries.GetLoginViewModelList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, UserName,request.Password,RememberMe" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<LoginViewModelVM>(query);
            return data.ToList();
        }
    }
}
