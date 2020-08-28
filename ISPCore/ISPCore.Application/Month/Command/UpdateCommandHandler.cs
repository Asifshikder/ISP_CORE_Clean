using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Month.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.Month.Update, MonthCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.Month> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Month> _repository;
        public async Task<MonthCommandVM> Handle(Commands.Month.Update request, CancellationToken cancellationToken)
        {
            var response = new MonthCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateMonth(request.MonthName);

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
