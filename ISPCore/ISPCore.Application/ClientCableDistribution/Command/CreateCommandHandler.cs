using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ClientCableDistribution.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.ClientCableDistribution.Create, ClientCableDistributionCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.ClientCableDistribution> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.ClientCableDistribution> _repository;

        public async Task<ClientCableDistributionCommandVM> Handle(Commands.ClientCableDistribution.Create request, CancellationToken cancellationToken)
        {
            var response = new ClientCableDistributionCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.ClientCableDistribution(request.CableQuantity,request.EmployeeID,request.ClientID,request.AssignEmployee);
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
