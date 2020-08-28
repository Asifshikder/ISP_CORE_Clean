using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.CableType.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.CableType.Create, CableTypeCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.CableType> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.CableType> _repository;

        public async Task<CableTypeCommandVM> Handle(Commands.CableType.Create request, CancellationToken cancellationToken)
        {
            var response = new CableTypeCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.CableType(request.CableTypeName);
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
