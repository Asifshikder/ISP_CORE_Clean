using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ActionList.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.ActionList.Update, ActionListCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.ActionList> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.ActionList> _repository;
        public async Task<ActionListCommandVM> Handle(Commands.ActionList.Update request, CancellationToken cancellationToken)
        {
            var response = new ActionListCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateActionList(request.FormID, request.ActionName, request.ActionValue, request.ActionDescription);

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
