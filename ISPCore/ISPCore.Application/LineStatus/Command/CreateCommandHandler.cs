using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.LineStatus.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.LineStatus.Create, LineStatusCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.LineStatus> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.LineStatus> _repository;

        public async Task<LineStatusCommandVM> Handle(Commands.LineStatus.Create request, CancellationToken cancellationToken)
        {
            var response = new LineStatusCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.LineStatus(request.LineStatusName);
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
