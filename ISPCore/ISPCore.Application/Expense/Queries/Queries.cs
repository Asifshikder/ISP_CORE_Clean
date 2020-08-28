using ISPCore.Application.Expense.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Expense.Queries
{
    public static class Queries
    {
        public class GetExpenseList : IRequest<List<ExpenseVM>>
        {
        }
        public class GetExpense : IRequest<ExpenseVM>
        {
            public int Id { get; set; }
        }
    }
}
