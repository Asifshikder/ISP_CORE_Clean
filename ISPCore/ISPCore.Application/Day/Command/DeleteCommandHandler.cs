using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Day.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.Day.MarkAsDelete, DayCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.Day> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.Day> _repository;
        public async Task<DayCommandVM> Handle(Commands.Day.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new DayCommandVM
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
