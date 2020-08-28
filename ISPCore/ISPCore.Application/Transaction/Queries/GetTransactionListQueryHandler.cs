using Dapper;
using ISPCore.Application.Transaction.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Transaction.Queries
{
    public class GetTransactionListQueryHandler : IRequestHandler<Queries.GetTransactionList, List<TransactionVM>>
    {
        public GetTransactionListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<TransactionVM>> Handle(Queries.GetTransactionList request, CancellationToken cancellationToken)
        {
            var query = $"select Id,  ClientDetailsID, PaymentTransaction, PaymentMonth, PackageID, PaymentTypeID, PaymentFrom, PaymentAmount, ResellerPaymentAmount, PackagePriceForResellerByAdminDuringCreateOrUpdate, PackagePriceForResellerUserByResellerDuringCreateOrUpdate, PaidAmount, DueAmount, PaymentStatus, Discount, WhoGenerateTheBill, EmployeeID, BillCollectBy, RemarksNo, ResetNo, PaymentDate, LineStatusID, AmountCountDate, IsNewClient, ChangePackageHowMuchTimes, ForWhichSignUpBills, PaymentFromWhichPage, ResellerID, PaymentGenerateUptoWhichDate, TransactionForWhichCycle, PermanentDiscount, AnotherMobileNo, PaymentBy" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<TransactionVM>(query);
            return data.ToList();
        }
    }
}
