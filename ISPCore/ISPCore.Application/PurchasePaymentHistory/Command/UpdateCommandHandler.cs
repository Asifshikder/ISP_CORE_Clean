using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.PurchasePaymentHistory.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.PurchasePaymentHistory.Update, PurchasePaymentHistoryCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.PurchasePaymentHistory> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.PurchasePaymentHistory> _repository;
        public async Task<PurchasePaymentHistoryCommandVM> Handle(Commands.PurchasePaymentHistory.Update request, CancellationToken cancellationToken)
        {
            var response = new PurchasePaymentHistoryCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdatePurchasePaymentHistory(request.PurchaseID, request.AccountListID, request.PaymentByID, request.PurchasePaymentDate, request.CheckNo, request.CheckName, request.CheckPath, request.CheckImageBytes, request.Description, request.PaymentAmount, request.PaymentPaidBy);

                await _repository.UpdateAsync(entity);

                response.Status = true;
                response.Message = "entity updated successfully.";
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
