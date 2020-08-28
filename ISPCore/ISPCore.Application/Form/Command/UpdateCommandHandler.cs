using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Form.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.Form.Update, FormCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.Form> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Form> _repository;
        public async Task<FormCommandVM> Handle(Commands.Form.Update request, CancellationToken cancellationToken)
        {
            var response = new FormCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateForm(request.FormName, request.ControllerNameID, request.FormValue, request.FormDescription, request.FormLocation);

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
