using Dapper;
using ISPCore.Application.SecurityQuestion.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.SecurityQuestion.Queries
{
    public class GetSecurityQuestionQueryHandler : IRequestHandler<Queries.GetSecurityQuestion, SecurityQuestionVM>
    {
        public GetSecurityQuestionQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<SecurityQuestionVM> Handle(Queries.GetSecurityQuestion request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetSecurityQuestionById({request.SecurityQuestionId})";
            var query = $"SELECT * from SecurityQuestion where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<SecurityQuestionVM>(query);
            return data;
        }
    }
}
