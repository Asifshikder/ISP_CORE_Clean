using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Distribution.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.Distribution.MarkAsDelete, DistributionCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.Distribution> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.Distribution> _repository;
        public async Task<DistributionCommandVM> Handle(Commands.Distribution.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new DistributionCommandVM
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
