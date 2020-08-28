using Dapper;
using ISPCore.Application.SecurityQuestion.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.SecurityQuestion.Queries
{
    public class GetSecurityQuestionListQueryHandler : IRequestHandler<Queries.GetSecurityQuestionList, List<SecurityQuestionVM>>
    {
        public GetSecurityQuestionListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<SecurityQuestionVM>> Handle(Queries.GetSecurityQuestionList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, SecurityQuestionName"+"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<SecurityQuestionVM>(query);
            return data.ToList();
        }
    }
}
