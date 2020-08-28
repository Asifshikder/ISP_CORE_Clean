using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.DistributionReason.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.DistributionReason.Create, DistributionReasonCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.DistributionReason> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.DistributionReason> _repository;

        public async Task<DistributionReasonCommandVM> Handle(Commands.DistributionReason.Create request, CancellationToken cancellationToken)
        {
            var response = new DistributionReasonCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.DistributionReason(request.DistributionReasonName);
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
