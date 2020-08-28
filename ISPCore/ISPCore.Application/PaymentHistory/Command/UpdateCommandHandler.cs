using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.PayementHistory.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.PayementHistory.Update, PayementHistoryCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.PayementHistory> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.PayementHistory> _repository;
        public async Task<PayementHistoryCommandVM> Handle(Commands.PayementHistory.Update request, CancellationToken cancellationToken)
        {
            var response = new PayementHistoryCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdatePayementHistory(request.TransactionID, request.ClientDetailsID, request.EmployeeID, request.ResellerID, request.CollectByID, request.PaidAmount, request.ResetNo, request.AdvancePaymentID, request.PaymentByID, request.NormalPayment, request.DiscountPayment, request.PaymentFromWhichPage, request.BillAcceptBy, request.AcceptStatus);

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
