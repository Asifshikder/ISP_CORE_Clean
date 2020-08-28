using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ClientCableAssign.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.ClientCableAssign.Create, ClientCableAssignCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.ClientCableAssign> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.ClientCableAssign> _repository;

        public async Task<ClientCableAssignCommandVM> Handle(Commands.ClientCableAssign.Create request, CancellationToken cancellationToken)
        {
            var response = new ClientCableAssignCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.ClientCableAssign(request.CableQuantity,request.EmployeeID);
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
