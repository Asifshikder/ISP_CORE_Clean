using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.PurchasePaymentHistory.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.PurchasePaymentHistory.MarkAsDelete, PurchasePaymentHistoryCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.PurchasePaymentHistory> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.PurchasePaymentHistory> _repository;
        public async Task<PurchasePaymentHistoryCommandVM> Handle(Commands.PurchasePaymentHistory.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new PurchasePaymentHistoryCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.MarkAsDelete();

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
