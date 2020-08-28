using Dapper;
using ISPCore.Application.Deposit.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ISPCore.Application.Deposit.Queries
{
    public class GetDepositListQueryHandler : IRequestHandler<Queries.GetDepositList, List<DepositVM>>
    {
        public GetDepositListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<DepositVM>> Handle(Queries.GetDepositList request, CancellationToken cancellationToken)
        {
            var query = $"select Id,Descriptions,DescriptionFileByte,DescriptionFilePath,HeadID,Amount,PaymentDate,CompanyID,AccountListID,PayerID,PaymentByID,DepositStatus,References,ResellerID" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<DepositVM>(query);
            return data.ToList();
        }
    }
}
