using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Head.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.Head.Create, HeadCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.Head> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Head> _repository;

        public async Task<HeadCommandVM> Handle(Commands.Head.Create request, CancellationToken cancellationToken)
        {
            var response = new HeadCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.Head(request.HeadName, request.HeadTypeID, request.ResellerID);
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
