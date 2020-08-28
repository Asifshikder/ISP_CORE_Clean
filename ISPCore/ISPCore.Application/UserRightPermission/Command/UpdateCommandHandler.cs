using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.UserRightPermission.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.UserRightPermission.Update, UserRightPermissionCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.UserRightPermission> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.UserRightPermission> _repository;
        public async Task<UserRightPermissionCommandVM> Handle(Commands.UserRightPermission.Update request, CancellationToken cancellationToken)
        {
            var response = new UserRightPermissionCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateUserRightPermission(request.UserRightPermissionName,request.UserRightPermissionDescription,request.UserRightPermissionDetails);

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
