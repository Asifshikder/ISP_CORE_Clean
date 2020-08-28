using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Transaction.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.Transaction.Create, TransactionCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.Transaction> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Transaction> _repository;

        public async Task<TransactionCommandVM> Handle(Commands.Transaction.Create request, CancellationToken cancellationToken)
        {
            var response = new TransactionCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.Transaction(request.ClientDetailsID,request.PaymentTransaction,request.PaymentMonth,request.PackageID,request.PaymentTypeID,request.PaymentFrom,request.PaymentAmount,request.ResellerPaymentAmount,request.PackagePriceForResellerByAdminDuringCreateOrUpdate,request.PackagePriceForResellerUserByResellerDuringCreateOrUpdate,request.PaidAmount,request.DueAmount,request.PaymentStatus,request.Discount,request.WhoGenerateTheBill,request.EmployeeID,request.BillCollectBy,request.RemarksNo,request.ResetNo,request.PaymentDate,request.LineStatusID,request.AmountCountDate,request.IsNewClient,request.ChangePackageHowMuchTimes,request.ForWhichSignUpBills,request.PaymentFromWhichPage,request.ResellerID,request.PaymentGenerateUptoWhichDate,request.TransactionForWhichCycle,request.PermanentDiscount,request.AnotherMobileNo,request.PaymentBy);
                var data = await _repository.AddAsync(entity);

                response.Status = true;
                response.Message = "entity created successfully.";
                response.Id = entity.Id;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }
    }
}
