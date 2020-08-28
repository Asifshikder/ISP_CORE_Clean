using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Box.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.Box.Create, BoxCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.Box> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Box> _repository;

        public async Task<BoxCommandVM> Handle(Commands.Box.Create request, CancellationToken cancellationToken)
        {
            var response = new BoxCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.Box(request.BoxName,request.ResellerID,request.BoxLocation);
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
