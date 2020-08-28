using Dapper;
using ISPCore.Application.Expense.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Expense.Queries
{
    public class GetExpenseQueryHandler : IRequestHandler<Queries.GetExpense, ExpenseVM>
    {
        public GetExpenseQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<ExpenseVM> Handle(Queries.GetExpense request, CancellationToken cancellationToken)
        {
            //var query = $"SELECT * from public.GetExpenseById({request.ExpenseId})";
            var query = $"SELECT * from Expense where ID=" + request.Id + "";

            var data = await _connection.QueryFirstAsync<ExpenseVM>(query);
            return data;
        }
    }
}
