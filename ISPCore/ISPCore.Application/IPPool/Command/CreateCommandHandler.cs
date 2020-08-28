using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.IPPool.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.IPPool.Create, IPPoolCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.IPPool> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.IPPool> _repository;

        public async Task<IPPoolCommandVM> Handle(Commands.IPPool.Create request, CancellationToken cancellationToken)
        {
            var response = new IPPoolCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.IPPool(request.IPPoolName,request.StartRange,request.EndRange);
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
