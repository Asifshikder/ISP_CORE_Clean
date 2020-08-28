using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.TimePeriodForSignal.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.TimePeriodForSignal.MarkAsDelete, TimePeriodForSignalCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.TimePeriodForSignal> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.TimePeriodForSignal> _repository;
        public async Task<TimePeriodForSignalCommandVM> Handle(Commands.TimePeriodForSignal.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new TimePeriodForSignalCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.MarkAsDelete();

                await _repository.UpdateAsync(entity);

                response.Status = true;
                response.Message = "entity updated successfully.";
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
