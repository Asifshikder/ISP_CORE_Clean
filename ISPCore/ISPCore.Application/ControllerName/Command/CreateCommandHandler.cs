using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ControllerName.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.ControllerName.Create, ControllerNameCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.ControllerName> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.ControllerName> _repository;

        public async Task<ControllerNameCommandVM> Handle(Commands.ControllerName.Create request, CancellationToken cancellationToken)
        {
            var response = new ControllerNameCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.ControllerName(request.ControllerNames,request.ControllerValue);
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
