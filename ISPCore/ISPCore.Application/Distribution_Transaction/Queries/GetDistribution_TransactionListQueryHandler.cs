using Dapper;
using ISPCore.Application.Distribution_Transaction.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Distribution_Transaction.Queries
{
    public class GetDistribution_TransactionListQueryHandler : IRequestHandler<Queries.GetDistribution_TransactionList, List<Distribution_TransactionVM>>
    {
        public GetDistribution_TransactionListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<Distribution_TransactionVM>> Handle(Queries.GetDistribution_TransactionList request, CancellationToken cancellationToken)
        {
            var query = $"select Id,StockDetailsID,SectionID,ProductStatusID,ItemName,BrandName,Serial,ClientName,EmployeeName,SectionName,ProductStatus" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<Distribution_TransactionVM>(query);
            return data.ToList();
        }
    }
}
