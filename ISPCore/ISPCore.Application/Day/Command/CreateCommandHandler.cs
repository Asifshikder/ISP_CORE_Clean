using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Day.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.Day.Create, DayCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.Day> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Day> _repository;

        public async Task<DayCommandVM> Handle(Commands.Day.Create request, CancellationToken cancellationToken)
        {
            var response = new DayCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.Day(request.DayName);
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
