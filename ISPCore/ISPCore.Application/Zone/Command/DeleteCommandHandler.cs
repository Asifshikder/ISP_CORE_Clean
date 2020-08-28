using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Zone.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.Zone.MarkAsDelete, ZoneCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.Zone> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.Zone> _repository;
        public async Task<ZoneCommandVM> Handle(Commands.Zone.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new ZoneCommandVM
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
