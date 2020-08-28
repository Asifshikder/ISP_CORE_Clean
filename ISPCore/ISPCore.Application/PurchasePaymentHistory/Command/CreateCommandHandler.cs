using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.PurchasePaymentHistory.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.PurchasePaymentHistory.Create, PurchasePaymentHistoryCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.PurchasePaymentHistory> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.PurchasePaymentHistory> _repository;

        public async Task<PurchasePaymentHistoryCommandVM> Handle(Commands.PurchasePaymentHistory.Create request, CancellationToken cancellationToken)
        {
            var response = new PurchasePaymentHistoryCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.PurchasePaymentHistory(request.PurchaseID,request.AccountListID,request.PaymentByID,request.PurchasePaymentDate,request.CheckNo,request.CheckName,request.CheckPath,request.CheckImageBytes,request.Description,request.PaymentAmount,request.PaymentPaidBy);
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
