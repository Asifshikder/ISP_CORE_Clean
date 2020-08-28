using Dapper;
using ISPCore.Application.AuthorViewModel.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.AuthorViewModel.Queries
{
    public class GetAuthorViewModelQueryHandler : IRequestHandler<Queries.GetAuthorViewModel, AuthorViewModelVM>
    {
        public GetAuthorViewModelQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<AuthorViewModelVM> Handle(Queries.GetAuthorViewModel request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetAuthorViewModelById({request.AuthorViewModelId})";
            var query = $"SELECT * from AuthorViewModel where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<AuthorViewModelVM>(query);
            return data;
        }
    }
}
