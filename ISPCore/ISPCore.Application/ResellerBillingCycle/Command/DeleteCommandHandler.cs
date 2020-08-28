using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ResellerBillingCycle.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.ResellerBillingCycle.MarkAsDelete, ResellerBillingCycleCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.ResellerBillingCycle> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.ResellerBillingCycle> _repository;
        public async Task<ResellerBillingCycleCommandVM> Handle(Commands.ResellerBillingCycle.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new ResellerBillingCycleCommandVM
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
