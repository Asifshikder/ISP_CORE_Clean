using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Form.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.Form.MarkAsDelete, FormCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.Form> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.Form> _repository;
        public async Task<FormCommandVM> Handle(Commands.Form.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new FormCommandVM
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
