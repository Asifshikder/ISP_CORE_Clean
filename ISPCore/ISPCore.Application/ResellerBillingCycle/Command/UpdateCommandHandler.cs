using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ResellerBillingCycle.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.ResellerBillingCycle.Update, ResellerBillingCycleCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.ResellerBillingCycle> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.ResellerBillingCycle> _repository;
        public async Task<ResellerBillingCycleCommandVM> Handle(Commands.ResellerBillingCycle.Update request, CancellationToken cancellationToken)
        {
            var response = new ResellerBillingCycleCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateResellerBillingCycle(request.Day);

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
