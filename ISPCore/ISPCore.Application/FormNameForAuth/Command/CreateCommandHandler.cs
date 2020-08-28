using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.FormNameForAuth.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.FormNameForAuth.Create, FormNameForAuthCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.FormNameForAuth> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.FormNameForAuth> _repository;

        public async Task<FormNameForAuthCommandVM> Handle(Commands.FormNameForAuth.Create request, CancellationToken cancellationToken)
        {
            var response = new FormNameForAuthCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.FormNameForAuth(request.FormName,request.IsGranted,request.ID,request.Text,request.@Checked);
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
