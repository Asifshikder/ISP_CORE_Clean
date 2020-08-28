using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.DistributionReason.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.DistributionReason.Update, DistributionReasonCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.DistributionReason> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.DistributionReason> _repository;
        public async Task<DistributionReasonCommandVM> Handle(Commands.DistributionReason.Update request, CancellationToken cancellationToken)
        {
            var response = new DistributionReasonCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateDistributionReason(request.DistributionReasonName);

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
