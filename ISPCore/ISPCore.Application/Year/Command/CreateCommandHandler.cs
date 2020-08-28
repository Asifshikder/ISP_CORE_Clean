using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Year.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.Year.Create, YearCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.Year> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Year> _repository;

        public async Task<YearCommandVM> Handle(Commands.Year.Create request, CancellationToken cancellationToken)
        {
            var response = new YearCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.Year(request.YearName);
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
