using Dapper;
using ISPCore.Application.AuthorViewModel.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.AuthorViewModel.Queries
{
    public class GetAuthorViewModelListQueryHandler : IRequestHandler<Queries.GetAuthorViewModelList, List<AuthorViewModelVM>>
    {
        public GetAuthorViewModelListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<AuthorViewModelVM>> Handle(Queries.GetAuthorViewModelList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, Name,IsAuthor" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<AuthorViewModelVM>(query);
            return data.ToList();
        }
    }
}
