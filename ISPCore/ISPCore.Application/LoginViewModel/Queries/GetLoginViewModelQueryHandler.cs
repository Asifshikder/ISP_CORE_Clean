using Dapper;
using ISPCore.Application.LoginViewModel.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.LoginViewModel.Queries
{
    public class GetLoginViewModelQueryHandler : IRequestHandler<Queries.GetLoginViewModel, LoginViewModelVM>
    {
        public GetLoginViewModelQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<LoginViewModelVM> Handle(Queries.GetLoginViewModel request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetLoginViewModelById({request.LoginViewModelId})";
            var query = $"SELECT * from LoginViewModel where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<LoginViewModelVM>(query);
            return data;
        }
    }
}
