using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.AdvancePayment.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.AdvancePayment.MarkAsDelete, AdvancePaymentCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.AdvancePayment> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.AdvancePayment> _repository;
        public async Task<AdvancePaymentCommandVM> Handle(Commands.AdvancePayment.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new AdvancePaymentCommandVM
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
