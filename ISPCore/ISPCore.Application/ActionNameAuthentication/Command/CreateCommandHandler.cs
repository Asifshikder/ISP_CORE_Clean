using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ActionNameAuthentication.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.ActionNameAuthentication.Create, ActionNameAuthenticationCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.ActionNameAuthentication> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.ActionNameAuthentication> _repository;

        public async Task<ActionNameAuthenticationCommandVM> Handle(Commands.ActionNameAuthentication.Create request, CancellationToken cancellationToken)
        {
            var response = new ActionNameAuthenticationCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.ActionNameAuthentication(request.ActionName,request.IsGranted,request.ID,request.Text,request.Checked);
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
