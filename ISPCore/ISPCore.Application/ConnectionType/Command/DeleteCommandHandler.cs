using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ConnectionType.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.ConnectionType.MarkAsDelete, ConnectionTypeCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.ConnectionType> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.ConnectionType> _repository;
        public async Task<ConnectionTypeCommandVM> Handle(Commands.ConnectionType.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new ConnectionTypeCommandVM
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
