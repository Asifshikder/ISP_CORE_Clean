using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ControllerName.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.ControllerName.Update, ControllerNameCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.ControllerName> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.ControllerName> _repository;
        public async Task<ControllerNameCommandVM> Handle(Commands.ControllerName.Update request, CancellationToken cancellationToken)
        {
            var response = new ControllerNameCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateControllerName(request.ControllerNames,request.ControllerValue);

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
