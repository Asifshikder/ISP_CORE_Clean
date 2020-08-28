using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.TimePeriodForSignal.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.TimePeriodForSignal.Create, TimePeriodForSignalCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.TimePeriodForSignal> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.TimePeriodForSignal> _repository;

        public async Task<TimePeriodForSignalCommandVM> Handle(Commands.TimePeriodForSignal.Create request, CancellationToken cancellationToken)
        {
            var response = new TimePeriodForSignalCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.TimePeriodForSignal(request.UpToHours,request.SignalSign);
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
