using Dapper;
using ISPCore.Application.Expense.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ISPCore.Application.Expense.Queries
{
    public class GetExpenseListQueryHandler : IRequestHandler<Queries.GetExpenseList, List<ExpenseVM>>
    {
        public GetExpenseListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<ExpenseVM>> Handle(Queries.GetExpenseList request, CancellationToken cancellationToken)
        {
            var query = $"select Id,Descriptions,DescriptionFileByte,DescriptionFilePath,HeadID,Amount,PaymentDate,CompanyID,AccountListID,PayerID,PaymentByID,ExpenseStatus,References,ResellerID" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<ExpenseVM>(query);
            return data.ToList();
        }
    }
}
