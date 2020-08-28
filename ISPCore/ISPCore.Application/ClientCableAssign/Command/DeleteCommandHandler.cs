using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ClientCableAssign.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.ClientCableAssign.MarkAsDelete, ClientCableAssignCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.ClientCableAssign> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.ClientCableAssign> _repository;
        public async Task<ClientCableAssignCommandVM> Handle(Commands.ClientCableAssign.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new ClientCableAssignCommandVM
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
