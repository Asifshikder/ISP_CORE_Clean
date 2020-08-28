using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ConnectionType.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.ConnectionType.Create, ConnectionTypeCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.ConnectionType> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.ConnectionType> _repository;

        public async Task<ConnectionTypeCommandVM> Handle(Commands.ConnectionType.Create request, CancellationToken cancellationToken)
        {
            var response = new ConnectionTypeCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.ConnectionType(request.ConnectionTypeName);
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
