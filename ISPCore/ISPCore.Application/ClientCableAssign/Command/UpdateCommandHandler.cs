using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ClientCableAssign.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.ClientCableAssign.Update, ClientCableAssignCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.ClientCableAssign> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.ClientCableAssign> _repository;
        public async Task<ClientCableAssignCommandVM> Handle(Commands.ClientCableAssign.Update request, CancellationToken cancellationToken)
        {
            var response = new ClientCableAssignCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateClientCableAssign(request.CableQuantity, request.EmployeeID);

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
