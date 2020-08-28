using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.FormNameForAuth.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.FormNameForAuth.MarkAsDelete, FormNameForAuthCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.FormNameForAuth> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.FormNameForAuth> _repository;
        public async Task<FormNameForAuthCommandVM> Handle(Commands.FormNameForAuth.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new FormNameForAuthCommandVM
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
