using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Role.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.Role.Create, RoleCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.Role> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Role> _repository;

        public async Task<RoleCommandVM> Handle(Commands.Role.Create request, CancellationToken cancellationToken)
        {
            var response = new RoleCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.Role(request.RoleName);
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
