using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ActionList.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.ActionList.MarkAsDelete, ActionListCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.ActionList> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.ActionList> _repository;
        public async Task<ActionListCommandVM> Handle(Commands.ActionList.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new ActionListCommandVM
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
