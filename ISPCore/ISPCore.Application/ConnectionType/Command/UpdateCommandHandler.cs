using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ConnectionType.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.ConnectionType.Update, ConnectionTypeCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.ConnectionType> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.ConnectionType> _repository;
        public async Task<ConnectionTypeCommandVM> Handle(Commands.ConnectionType.Update request, CancellationToken cancellationToken)
        {
            var response = new ConnectionTypeCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateConnectionType(request.ConnectionTypeName);

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
