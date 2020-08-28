using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Year.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.Year.Update, YearCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.Year> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Year> _repository;
        public async Task<YearCommandVM> Handle(Commands.Year.Update request, CancellationToken cancellationToken)
        {
            var response = new YearCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateYear(request.YearName);

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
