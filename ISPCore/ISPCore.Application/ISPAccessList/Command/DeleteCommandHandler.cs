using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ISPAccessList.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.ISPAccessList.MarkAsDelete, ISPAccessListCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.ISPAccessList> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.ISPAccessList> _repository;
        public async Task<ISPAccessListCommandVM> Handle(Commands.ISPAccessList.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new ISPAccessListCommandVM
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
