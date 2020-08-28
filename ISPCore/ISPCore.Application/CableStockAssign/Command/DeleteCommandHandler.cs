using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ClientStockAssign.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.ClientStockAssign.MarkAsDelete, ClientStockAssignCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.ClientStockAssign> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.ClientStockAssign> _repository;
        public async Task<ClientStockAssignCommandVM> Handle(Commands.ClientStockAssign.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new ClientStockAssignCommandVM
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
