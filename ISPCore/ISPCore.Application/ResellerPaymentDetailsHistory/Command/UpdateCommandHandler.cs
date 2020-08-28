using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ResellerPaymentDetailsHistory.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.ResellerPaymentDetailsHistory.Update, ResellerPaymentDetailsHistoryCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.ResellerPaymentDetailsHistory> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.ResellerPaymentDetailsHistory> _repository;
        public async Task<ResellerPaymentDetailsHistoryCommandVM> Handle(Commands.ResellerPaymentDetailsHistory.Update request, CancellationToken cancellationToken)
        {
            var response = new ResellerPaymentDetailsHistoryCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateResellerPaymentDetailsHistory(request.ResellerPaymentID, request.ResellerID, request.ResellerPaymentGivenTypeID, request.ActionTypeID, request.LastAmount, request.PaymentAmount, request.DeleteTimeResellerAmount, request.PaymentYear, request.PaymentMonth, request.PaymentStatus, request.PaymentCheckOrAnySerial, request.CollectBy, request.ActiveBy, request.PaymentByID, request.PaymenReceivedDate);

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
