using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Pop.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.Pop.Create, PopCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.Pop> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Pop> _repository;

        public async Task<PopCommandVM> Handle(Commands.Pop.Create request, CancellationToken cancellationToken)
        {
            var response = new PopCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.Pop(request.PopName,request.PopLocation);
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
