using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Box.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.Box.MarkAsDelete, BoxCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.Box> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.Box> _repository;
        public async Task<BoxCommandVM> Handle(Commands.Box.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new BoxCommandVM
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
