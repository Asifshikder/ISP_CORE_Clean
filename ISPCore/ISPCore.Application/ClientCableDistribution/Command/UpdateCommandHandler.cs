using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ClientCableDistribution.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.ClientCableDistribution.Update, ClientCableDistributionCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.ClientCableDistribution> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.ClientCableDistribution> _repository;
        public async Task<ClientCableDistributionCommandVM> Handle(Commands.ClientCableDistribution.Update request, CancellationToken cancellationToken)
        {
            var response = new ClientCableDistributionCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateClientCableDistribution(request.CableQuantity, request.EmployeeID, request.ClientID, request.AssignEmployee);

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
