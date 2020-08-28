using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Day.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.Day.Update, DayCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.Day> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Day> _repository;
        public async Task<DayCommandVM> Handle(Commands.Day.Update request, CancellationToken cancellationToken)
        {
            var response = new DayCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateDay(request.DayName);

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
