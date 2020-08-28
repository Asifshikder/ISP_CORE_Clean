using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Role.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.Role.Update, RoleCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.Role> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Role> _repository;
        public async Task<RoleCommandVM> Handle(Commands.Role.Update request, CancellationToken cancellationToken)
        {
            var response = new RoleCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateRole(request.RoleName);

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
