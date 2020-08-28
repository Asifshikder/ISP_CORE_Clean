using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.UserRightPermission.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.UserRightPermission.Create, UserRightPermissionCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.UserRightPermission> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.UserRightPermission> _repository;

        public async Task<UserRightPermissionCommandVM> Handle(Commands.UserRightPermission.Create request, CancellationToken cancellationToken)
        {
            var response = new UserRightPermissionCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.UserRightPermission(request.UserRightPermissionName,request.UserRightPermissionDescription,request.UserRightPermissionDetails);
                var data = await _repository.AddAsync(entity);

                response.Status = true;
                response.Message = "entity created successfully.";
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
