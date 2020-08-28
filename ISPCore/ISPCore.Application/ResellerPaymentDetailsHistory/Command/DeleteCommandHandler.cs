using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ResellerPaymentDetailsHistory.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.ResellerPaymentDetailsHistory.MarkAsDelete, ResellerPaymentDetailsHistoryCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.ResellerPaymentDetailsHistory> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.ResellerPaymentDetailsHistory> _repository;
        public async Task<ResellerPaymentDetailsHistoryCommandVM> Handle(Commands.ResellerPaymentDetailsHistory.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new ResellerPaymentDetailsHistoryCommandVM
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
