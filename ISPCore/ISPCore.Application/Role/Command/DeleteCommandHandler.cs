using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Role.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.Role.MarkAsDelete, RoleCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.Role> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.Role> _repository;
        public async Task<RoleCommandVM> Handle(Commands.Role.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new RoleCommandVM
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
